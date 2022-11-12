# HTTP 5112 Cumulative 1

## Database:
- [/Models/SchoolDbContext.cs](HTTP5112_Cumulative_1/Models/SchoolDbContext.cs)
- A class which connects to MySQL school database

## Layout:
![The layout of the Home Page](https://github.com/ceciaups/HTTP5112_Cumulative_1/blob/master/capture/layout.PNG)
- [/Views/Shared/_Layout.cshtml](HTTP5112_Cumulative_1/Views/Shared/_Layout.cshtml)
- The layout of the web application

## Teacher:
![The layout of the Teacher Page](https://github.com/ceciaups/HTTP5112_Cumulative_1/blob/master/capture/teacher.PNG)
| Type | Description | File |
| --- | --- | --- |
| Controller | A WebAPI Controller which accesses information about teachers | [/Controllers/TeacherDataController.cs](HTTP5112_Cumulative_1/Controllers/TeacherDataController.cs) |
| Controller | A Controller which routes to List/Show Pages | [/Controllers/TeacherController.cs](HTTP5112_Cumulative_1/Controllers/TeacherController.cs) |
| Model | A Model which represents information about a teacher | [/Models/Teacher.cs](HTTP5112_Cumulative_1/Models/Teacher.cs) |
| View | A View which uses server rendering to display list of teachers' names from the MySQL Database | [/Views/Teacher/List.cshtml](HTTP5112_Cumulative_1/Views/Teacher/List.cshtml) |
| View | A View which uses server rendering to display the information of a teacher from the MySQL Database | [/Views/Teacher/Show.cshtml](HTTP5112_Cumulative_1/Views/Teacher/Show.cshtml) |

## Student:
![The layout of the Student Page](https://github.com/ceciaups/HTTP5112_Cumulative_1/blob/master/capture/student.PNG)
| Type | Description | File |
| --- | --- | --- |
| Controller | A WebAPI Controller which accesses information about students | [/Controllers/StudentDataController.cs](HTTP5112_Cumulative_1/Controllers/StudentDataController.cs) |
| Controller | A Controller which routes to List/Show Pages | [/Controllers/StudentController.cs](HTTP5112_Cumulative_1/Controllers/StudentController.cs) |
| Model | A Model which represents information about a student | [/Models/Student.cs](HTTP5112_Cumulative_1/Models/Student.cs) |
| View | A View which uses server rendering to display list of students' names from the MySQL Database | [/Views/Student/List.cshtml](HTTP5112_Cumulative_1/Views/Student/List.cshtml) |
| View | A View which uses server rendering to display the information of a student from the MySQL Database | [/Views/Student/Show.cshtml](HTTP5112_Cumulative_1/Views/Student/Show.cshtml) |

## Class:
![The layout of the Class Page](https://github.com/ceciaups/HTTP5112_Cumulative_1/blob/master/capture/class.PNG)
| Type | Description | File |
| --- | --- | --- |
| Controller | A WebAPI Controller which accesses information about classes | [/Controllers/ClassDataController.cs](HTTP5112_Cumulative_1/Controllers/ClassDataController.cs) |
| Controller | A Controller which routes to List/Show Pages | [/Controllers/ClassController.cs](HTTP5112_Cumulative_1/Controllers/ClassController.cs) |
| Model | A Model which represents information about a class | [/Models/Class.cs](HTTP5112_Cumulative_1/Models/Student.cs) |
| View | A View which uses server rendering to display list of classs' codes from the MySQL Database | [/Views/Class/List.cshtml](HTTP5112_Cumulative_1/Views/Class/List.cshtml) |
| View | A View which uses server rendering to display the information of a class from the MySQL Database | [/Views/Class/Show.cshtml](HTTP5112_Cumulative_1/Views/Class/Show.cshtml) |