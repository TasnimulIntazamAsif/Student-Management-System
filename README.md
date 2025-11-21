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

| Student List | Student Details | Create Student | Edit Student | Delete Confirmation |
|:---:|:---:|:---:|:---:|:---:|
| ![Student List](screenshots/student-list.png) | ![Student Details](screenshots/student-details.png) | ![Create Student](screenshots/create-student.png) | ![Edit Student](screenshots/edit-student.png) | ![Delete Student](screenshots/delete-student.png) |

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