# MemoryPalaceAuth Documentation

## Overview
MemoryPalaceAuth is an innovative application designed to create a memory palace using a combination of **Flask (backend), Vue.js (web frontend), and Unity (mobile VR/AR)**. This system enables users to store and recall information by associating it with spatial locations in an interactive 3D environment, accessible on both **PC and mobile**.

---

## Project Structure

```
MemoryPalaceAuth/
│── backend/                    # Flask Backend (Python)
│   ├── app.py                  # Main API Server
│   ├── database.py             # Handles SQLite Database
│   ├── models.py               # Defines Data Models
│   ├── routes.py               # API Routes for Authentication
│   ├── requirements.txt        # Dependencies
│   └── config.py               # App Configurations
│
│── frontend-web/                # Web (PC & Mobile)
│   ├── src/
│   │   ├── components/
│   │   │   ├── MemoryPalace.vue # 3D Visualization
│   │   │   ├── Login.vue        # Login Component
│   │   ├── assets/              # Images & Sounds
│   │   ├── App.vue              # Main UI
│   │   ├── main.js              # Vue Initialization
│   ├── public/
│   ├── package.json             # Dependencies
│   ├── vite.config.js           # Vite Configuration
│
│── mobile-vr-ar/                # Unity (VR & Mobile)
│   ├── Assets/
│   │   ├── Scripts/
│   │   │   ├── MemoryPalaceManager.cs  # Manages 3D Palaces
│   │   │   ├── GestureController.cs     # Handles User Gestures
│   │   ├── Models/
│   │   ├── Prefabs/
│   ├── Scenes/
│   ├── ProjectSettings/
│   ├── memorypalace.unity        # Main Unity Scene
│
└── README.md                     # Full Documentation
```

---

## Backend - Flask API

### Setup
1. Install dependencies:
   ```sh
   pip install -r requirements.txt
   ```
2. Run the server:
   ```sh
   python app.py
   ```

### API Endpoints
- `POST /register` - Register a new user.
- `POST /login` - Authenticate user.
- `GET /memorypalace/{user_id}` - Retrieve stored memory palace data.
- `POST /memorypalace/{user_id}` - Store memory palace information.

---

## Frontend - Vue.js

### Setup
1. Install dependencies:
   ```sh
   npm install
   ```
2. Run the Vue development server:
   ```sh
   npm run dev
   ```

### Key Components
- **MemoryPalace.vue** - Renders the 3D visualization using WebGL.
- **Login.vue** - Handles authentication and user sessions.
- **App.vue** - Main application structure.

---

## Mobile VR/AR - Unity

### Setup
1. Open the Unity project (`memorypalace.unity`) in **Unity 2021+**.
2. Ensure the **AR Foundation Package** is installed.
3. Connect a mobile device and build the project.

### Key Scripts
- **MemoryPalaceManager.cs** - Initializes and manages memory palaces.
- **GestureController.cs** - Handles user interactions (drag, zoom, rotate).

---

## Features & Functionality
- **User Authentication** - Secure login and registration using Flask JWT.
- **3D Memory Palace** - Users can create and navigate a virtual environment.
- **Web & Mobile Support** - Vue.js for web, Unity for mobile AR/VR.
- **Gesture Control** - Interact with objects using touch gestures.

---

## Future Enhancements
- Multi-user collaboration.
- AI-powered suggestions for memory enhancement.
- Integration with external databases for syncing.

---

## Contributors
- **Project Lead**: [Your Name]
- **Developers**: [Team Members]
- **Special Thanks**: Open-source libraries & frameworks

---

## License
MIT License - Free for personal and educational use.

