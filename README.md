# MyNotes

# Notes API (Minimal ASP.NET Core Project)

A simple REST API for managing notes, built using C# and ASP.NET Core Minimal APIs.  
This project is beginner-friendly, with in-memory storage and automated unit testing.

---

## Features

- **CRUD Operations**: Create, read, update, and delete notes.
- **In-memory Storage**: Data is lost when the app restarts (no database yet).
- **Minimal API**: All endpoints defined in `Program.cs`, using latest .NET best practices.
- **Automated Test**: Unit test for the Note model with xUnit.

---

## Folder Structure
MyNotes/ ├── NotesApi/ │ ├── Program.cs // Main API code and endpoints │ └── Note.cs // Note model (with namespace) ├── NotesApi.Tests/ │ └── UnitTest1.cs // xUnit test for Note model


---

## How to Run the API

1. **Navigate to the project folder:**
    ```bash
    cd MyNotes/NotesApi
    ```

2. **Run the API:**
    ```bash
    dotnet run
    ```

3. **Open Swagger UI in your browser:**  
    By default: [https://localhost:5001/swagger](https://localhost:5001/swagger)

4. **Try the Endpoints:**
    - `GET /notes` - List all notes
    - `POST /notes` - Create a new note (send JSON)
    - `GET /notes/{id}` - Get a note by ID
    - `PUT /notes/{id}` - Update a note
    - `DELETE /notes/{id}` - Delete a note

> **Note:** All data is stored in memory; restarting the API will clear your notes.

---

## How to Run Tests

1. **Navigate to the test project:**
    ```bash
    cd MyNotes/NotesApi.Tests
    ```

2. **Run tests:**
    ```bash
    dotnet test
    ```

---

## Next Steps / To-Do

- Add database persistence (SQLite, Entity Framework Core)
- Add validation and error handling
- Write more comprehensive tests (API/integration)
- Add authentication (JWT)
- Connect a frontend (Angular/React)
- Deploy to the cloud

---

## Useful Commands

- `dotnet run` &nbsp;&nbsp;→ Run the API
- `dotnet test` &nbsp;→ Run automated tests

---

## Resources

- [Minimal APIs in .NET](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis)
- [xUnit testing for .NET](https://xunit.net/docs/getting-started/netcore/cmdline)

---

*Project by Sumit Akoliya — follow step-by-step progress for future updates!*
