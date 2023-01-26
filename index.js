import express from 'express';
import dotenv from 'dotenv'

const app = express()
app.use(express.json())
dotenv.config()

let todos = [
    {
        userId: 1,
        id: 1,
        title: "Studia storia",
        completed: true
    },
    {
        userId: 1,
        id: 2,
        title: "Cucina 10 pankackes oggi",
        completed: true
    }
]

app.get('/todos', (req, res) => {
    if (req.query.userId) {
        console.log(req.query.userId)
        const result = todos.filter(todo => todo.userId == req.query.userId)
        res.status(200).json(result)
    } else {
        res.status(200).json(todos)
    }
})

app.post('/todos', (req, res) => {
    let newTodo = req.body
    newTodo.id = todos.length + 1
    console.log(newTodo)
    todos.push(newTodo)
    res.status(201).json({ message: 'Created' })
})

app.delete('/todos/:id', (req, res) => {
    const todoId = req.params.id
    todos = todos.filter(todo => todo.id != todoId)
    res.status(200).json({ message: 'Operation completed' });
})

app.put('/todos/:id', (req, res) => {
    const pos = todos.findIndex(todo => todo.id == req.body.id)
    todos[pos] = req.body
    res.status(200).json({ message: 'Item modified '})
})

app.listen(process.env.port, () => {
    console.log(`Server running on port ${ process.env.port }`)
})