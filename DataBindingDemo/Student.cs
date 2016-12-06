﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DataBindingDemo
{
    // Student is a simple class that stores a name and an IsEnrolled value.
    public class Student
    {
        // The default constructor is required for creation from XAML.
        public Student()
        { }

        // The StudentName property is a string that holds the first and last name.
        public string StudentName { get; set; }

        // The IsEnrolledd property gets or sets a value indicating whether the student is currently enrolled.
        public bool IsEnrolled { get; set; }
    }

    // The StudentList collection is decleared for convenience,
    // because declaring generic types in XAML is inconvenient
    public class StudentList : ObservableCollection<Student>
    { }
}
