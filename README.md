# Student Management System 🚀

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com/Bishwaprotapi/StudentManagementSystem/actions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Stars](https://img.shields.io/github/stars/Bishwaprotapi/StudentManagementSystem?style=social)](https://github.com/Bishwaprotapi/StudentManagementSystem/stargazers)

---

<div align="center">
  <img src="screenshots/animated-demo.gif" alt="Student Management System Demo" width="700"/>
  <br>
  <em>✨ Modern, Responsive, and Easy-to-Use Student Management Web App ✨</em>
</div>

---

## 🎬 Feature Animations

| 🔍 Search Students | ➕ Add Student | ✏️ Edit Student | 🗑️ Delete Student |
|:---:|:---:|:---:|:---:|
| ![Search Animation](screenshots/animation-search.gif) | ![Add Animation](screenshots/animation-add.gif) | ![Edit Animation](screenshots/animation-edit.gif) | ![Delete Animation](screenshots/animation-delete.gif) |

*Above: Animated demos of the main features. Replace these with your own GIFs for maximum effect!*

---

## ✨ Screenshots



<img width="720" height="539" alt="Create New Stduent" src="https://github.com/user-attachments/assets/9efeaed3-8a3c-439a-b111-423ea2d34665" />
<img width="720" height="700" alt="Edit Student" src="https://github.com/user-attachments/assets/61ab6ed0-fdd9-44e3-859a-a24d91b35b15" />
<img width="1380" height="459" alt="student-list" src="https://github.com/user-attachments/assets/6da6358a-d5f0-4623-af6a-7d9d7a4edb1a" />
<img width="555" height="321" alt="Delete Student" src="https://github.com/user-attachments/assets/a6cc5d3a-dab5-4faf-9f84-dabd76651455" />
<img width="806" height="147" alt="Database" src="https://github.com/user-attachments/assets/8c91e144-64a9-44a6-a1e5-007eb40b8349" />

---

## 🎯 Features

- **Student Management**
  - ➕ Create, 📖 Read, ✏️ Update, and 🗑️ Delete student records
  - 👁️ View detailed student information
  - 🖼️ Upload and manage student photos
  - 🔍 Search functionality for quick access

- **Student Information**
  - 🆔 Student ID
  - 🧑‍🎓 Full Name
  - 📧 Email Address
  - 📱 Phone Number
  - 🏫 Department
  - 🖼️ Profile Photo

- **User Interface**
  - 📱 Responsive design for all devices
  - 🎨 Modern and clean interface
  - 🧭 Intuitive navigation
  - ⚡ Real-time search
  - ✅ Success notifications
  - 🖥️ Auto-adjusting layouts

---

## 🛠️ Technologies Used

- **Backend:** ASP.NET Core 8.0, Entity Framework Core, SQL Server
- **Frontend:** Bootstrap 5, Font Awesome, jQuery, HTML5/CSS3

---

## ⚡ Quick Start

```bash
# Clone the repository
$ git clone https://github.com/Bishwaprotapi/StudentManagementSystem.git
$ cd StudentManagementSystem

# Update your appsettings.json with your SQL Server connection string

# Setup the database
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update

# Run the application
$ dotnet run
```

---

## 🗂️ Project Structure

```
StudentManagementSystem/
├── Controllers/
├── Models/
├── Views/
│   └── Students/
├── Context/
├── wwwroot/
│   └── uploads/
├── appsettings.json
└── README.md
```

---

## 💡 Usage

- **View Students:** See all students, search, and view details
- **Add Student:** Fill in the form and upload a photo
- **Edit Student:** Update info and change photo
- **Delete Student:** Confirm before removing

---

## 🔥 Features in Detail

- **🔍 Search:** By name, email, or department
- **🖼️ Photo Management:** Upload, resize, and default placeholder
- **📱 Responsive:** Mobile-friendly, auto-adjusting layouts

---

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 🙏 Acknowledgments

- Bootstrap for the responsive design framework
- Font Awesome for the icons
- ASP.NET Core team for the excellent framework

---

> **Tip:** Replace `screenshots/animated-demo.gif` and the feature GIFs above with your own animated demos for maximum effect! 
