﻿using Recap_Library.Models;


Person myPerson = new Person("Naumche", 27);

myPerson.Greet();

Student student = new Student();

student.SetAge(21);

string intro = student.Introduce();

WriteLine(intro);

StudentProfesorTest studentProfesorTest = new StudentProfesorTest();
studentProfesorTest.Main();

