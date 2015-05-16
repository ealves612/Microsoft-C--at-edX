using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/* I know that we must create files to each class but it is no possible to upload multiple files to be assessed.
 So I decided to put everything in one single file and tried to do my best organizing and making it readable.*/

namespace assignment1
{   
    class Person
    {
        // Member Variables //

        private string _pFName;
        private string _pLName;
        private long   _pPhNumber;
        private string _pCity;
        private string _pAddress;
        private string _pState;
        private long   _pZip;
        private string _pCountry;

        // Accessors // 

        public string PFName
        {
            get { return _pFName; }
            set { _pFName = value; }
        }

        public string PLName
        {
            get { return _pLName; }
            set { _pLName = value; }
        }

        public long PPhNumber
        {
            get { return _pPhNumber; }
            set { _pPhNumber = value; }
        }

        public string PCity
        {
            get { return _pCity; }
            set { _pCity = value; }
        }

        public string PAddress
        {
            get { return _pAddress; }
            set { _pAddress = value; }
        }

        public string PState
        {
            get { return _pState; }
            set { _pState = value; }
        }

        public long PZip
        {
            get { return _pZip; }
            set { _pZip = value; }
        }

        public string PCountry
        {
            get { return _pCountry; }
            set { _pCountry = value; }
        }
    }

    class Student : Person
    {   
        // Member Variables //

        private static int _countStudent;
        private long   _studentId;
        private Stack Grades = new Stack();

        //

        public void TakeTest(){}

        // Constructors //

        public Student(string fName, string lName, string addr, string cty, string stProvince, long zip, string cntry, long stuId)
        {
            PFName = fName;
            PLName = lName;
            PAddress = addr;
            PCity = cty;
            PState = stProvince;
            PZip = zip;
            PCountry = cntry;
            StudentId = stuId;
            _countStudent++;
        }

        // Accessors //
        
        public long StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public Stack Grades1
        {
            get { return Grades; }
            set { Grades = value; }
        }

        public int CountStudent
        {
            get { return Student._countStudent;}
        }
    }

    class Course
    {   
        // Member Variables //

        private string _goalOfTheCourse;
        private double _minimumGpaGrad;
        ArrayList Student = new ArrayList();
        private Teacher[] teach = new Teacher[3];
        private string _nameOfTheCourse;
        public void ListStudent()
        {
            foreach(Student stdnt in Student)
            {
                Console.WriteLine("Student Name: {1}, {0}", stdnt.PFName, stdnt.PLName);
            }
        }

        // Constructors //

        public Course(){}

        public Course(string goal, double minGpa, string name)
        {
            _goalOfTheCourse = goal;
            _minimumGpaGrad = minGpa;
            _nameOfTheCourse = name;
        }

        // Accessors //

        public string GoalOfTheCourse
        {
            get { return _goalOfTheCourse; }
            set { _goalOfTheCourse = value; }
        }
        
        public double MinimumGpaGrad
        {
            get { return _minimumGpaGrad; }
            set { _minimumGpaGrad = value; }
        }

        public ArrayList Student1
        {
            get { return Student; }
            set { Student = value; }
        }

        internal Teacher[] Teach // Methods to get/set the array of Teachers
        {
            get { return teach; }
            set { teach = value; }
        }

        public string NameOfTheCourse
        {
            get { return _nameOfTheCourse; }
            set { _nameOfTheCourse = value; }
        }
    }

    class Teacher :  Person
    {   
        // Member Variables //

        //private string _profFirstName;
        //private string _profLastName;
        private string _officeLocation;
        private string _departament;
        //private long   _phoneNumber;
        private string _position;

        //
 
        public void GradeTest ()
        {}

        // Constructors //

        public Teacher() {}

        // As you may have noticed, I didn't implement all the variables in Teacher and Student so that
        // I could use the same constructors that I had before in Module 5 assignment

        public Teacher(string fName, string lName, string oLoc, string dep, long num, string pos)
        {
            PFName = fName;
            PLName = lName;
            _officeLocation = oLoc;
            _departament = dep;
            PPhNumber = num;
            _position = pos;
        }

        // Accessors //
        
        //public string ProfFirstName
        //{
        //    get { return _profFirstName; }
        //    set { _profFirstName = value; }
        //}
        
        //public string ProfLastName
        //{
        //    get { return _profLastName; }
        //    set { _profLastName = value; }
        //}

        public string OfficeLocation
        {
            get { return _officeLocation; }
            set { _officeLocation = value; }
        }

        public string Departament
        {
            get { return _departament; }
            set { _departament = value; }
        }

        //public long PhoneNumber
        //{
        //    get { return _phoneNumber; }
        //    set { _phoneNumber = value; }
        //}

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }

    class UProgram
    {
        private string _programName;
        private string _degreesOffered;
        private string _depHead;
        private Degree deg = new Degree();

        // Constructors //

        public UProgram()
        {
            _programName = null;
            _degreesOffered = null;
            _depHead = null;
        }

        public UProgram(string pName, string dOffer, string dHead)
        {
            _programName = pName;
            _degreesOffered = dOffer;
            _depHead = dHead;
        }

        // Accessors //

        public string ProgramName
        {
            get { return _programName; }
            set { _programName = value; }
        }
       
        public string DegreesOffered
        {
            get { return _degreesOffered; }
            set { _degreesOffered = value; }
        }

        public string DepHead
        {
            get { return _depHead; }
            set { _depHead = value; }
        }

        internal Degree Deg
        {
            get { return deg; }
            set { deg = value; }
        }
        
    }

    class Degree
    {
        // Member Variables //

        private string _degreeName;
        private string _degreeType;
        private int _creditsRequired;
        private int _coreHours;
        private int _electiveHours;
        private Course crs = new Course();

        // Constructors //

        public Degree()
        {
            _degreeName = null;
            _degreeType = null;
            _creditsRequired = 0;
            _coreHours = 0;
            _electiveHours = 0;
        }

        public Degree(string dName, string dType, int cReq, int cHours, int eHours)
        {
            _degreeName = dName;
            _degreeType = dType;
            _creditsRequired = cReq;
            _coreHours = cHours;
            _electiveHours = eHours;
        }

        // Accessors //

        public string DegreeName
        {
            get { return _degreeName; }
            set { _degreeName = value; }
        }
        
        public string DegreeType
        {
            get { return _degreeType; }
            set { _degreeType = value; }
        }
        
        public int CreditsRequired
        {
            get { return _creditsRequired; }
            set { _creditsRequired = value; }
        }
        
        public int CoreHours
        {
            get { return _coreHours; }
            set { _coreHours = value; }
        }
        
        public int ElectiveHours
        {
            get { return _electiveHours; }
            set { _electiveHours = value; }
        }

        internal Course Crs // Methods for Course object
        {
            get { return crs; }
            set { crs = value; }
        }
    }

    class Program
    {
        void dList(Student x)
        {
            x.Grades1.Push(100);
            x.Grades1.Push(83);
            x.Grades1.Push(92);
        }

        static void Main(string[] args)
        {
            // Instantiate three Student objects //

            Student e1 = new Student("John", "Appleseed", "239 Cedar Tree", "New York", "New York", 10928,"USA", 278367);
            Student e2 = new Student("Adam", "May", "76 Trash Free", "New York", "New York", 10321, "USA", 290389);
            Student e3 = new Student("Eve", "Boss", "4 Hashbrowns", "New York", "New York", 11402, "USA", 796843);

            // Instantiate a Course object called Programming with C# //

            Course programmingWithCSharp = new Course("Learn", 2.0, "Programming With C#");

            // Add your three students to this Course object //

            programmingWithCSharp.Student1.Add(e1);
            programmingWithCSharp.Student1.Add(e2);
            programmingWithCSharp.Student1.Add(e3);

            // Instantiate at least one Teacher object //

            Teacher t1 = new Teacher("Michael", "Lambert", "R.1", "Computer Science", 9857443354, "Professor");
            Teacher t2 = new Teacher("Mauren", "Parks", "A.9", "Computer Science", 7327264344, "Dean");
            Teacher t3 = new Teacher("Karen", "Milligan", "L.3", "Computer Science", 2489082469, "Professor");

            // Add that Teacher object to your Course object //

            programmingWithCSharp.Teach[0] = t1;
            programmingWithCSharp.Teach[1] = t2;
            programmingWithCSharp.Teach[2] = t3;

            // Instantiate a Degree object, such as Bachelor //

            Degree bachelors = new Degree("Bachelor of Science", "Undergraduate", 0, 40, 90);

            // Add your Course object to the Degree object //

            bachelors.Crs = programmingWithCSharp;

            // Instantiate a UProgram object called Information Technology //

            UProgram informationTechnology = new UProgram("Information Technology", "Something", "Eve Boss");

            // Add the Degree object to the UProgram object //

            informationTechnology.Deg = bachelors;

            // Add 5 Grades to each student //

            // Student 1 //

            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(93);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(100);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(45);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(93);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(79);

            // Student 2 //

            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(100);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(72);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(96);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(84);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(99);

            // Student 3 //

            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(53);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(65);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(41);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(95);
            ((Student)informationTechnology.Deg.Crs.Student1[0]).Grades1.Push(91);

            Console.WriteLine("The {0} program contains the {1} degree\n", informationTechnology.ProgramName, informationTechnology.Deg.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}\n", informationTechnology.Deg.DegreeName, informationTechnology.Deg.Crs.NameOfTheCourse);
            Console.WriteLine("The {0} contains {1} student(s)\n", informationTechnology.Deg.Crs.NameOfTheCourse, ((Student)informationTechnology.Deg.Crs.Student1[0]).CountStudent);

            // Output the students name //

            informationTechnology.Deg.Crs.ListStudent();
        }
    }
}