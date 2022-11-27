using System;
using System.Collections.Generic;

class Program{
    static PersonList personList;
    public static void Main(string[] args){
        Console.Clear();
        Program.personList = new PersonList();
        Menu();
        
    }

    public static void Menu(){
        Console.Clear();
        PrintMenu();
        SelectedMenu();

    }

    static void PrintMenu(){
        Console.WriteLine(" Welcome into the Kmutt shuttle booking program ");
        Console.WriteLine("------------- What do you want to do? -------------");
        Console.WriteLine(" 1.Registration");
        Console.WriteLine(" 2.Login");
        Console.WriteLine(" 3.Guest Login");
        Console.WriteLine(" 4.Exit");
        Console.WriteLine("---------------------------------------------------");
    }

    static void SelectedMenu(){
        Console.Write(" Please input selected menu : ");

        int m = int.Parse(Console.ReadLine());
        switch (m){
            case 1 : {
                RegistrationMenu();
                break;
                }
            case 2 : {
                LoginMenu();
                break;
                }
            case 3 : {
                GuestLoginMenu();
                break;
                }
            case 4 : break;
            default : {
                Console.WriteLine("Sorry please selected menu again.");
                Console.ReadLine();
                Menu();
                break;
                }
            }
    }


    //---------------------------------------------------Registration---------------------------------------------------
    static void RegistrationMenu(){
        Console.Clear();
        PrintRegistrationMenu();
        SelectedRegistrationMenu();
    }

    static void PrintRegistrationMenu(){
        Console.WriteLine(" Please select register type");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine(" 1.Personnel");
        Console.WriteLine(" 2.Student");
        Console.WriteLine(" 3.Back");
        Console.WriteLine("---------------------------------------------------");
    }
    
    static void SelectedRegistrationMenu(){
        Console.Write(" Please input selected type : ");

        int r = int.Parse(Console.ReadLine());
        switch (r){
            case 1 : {
                PersonnelRegistration();
                break;
            }
            case 2 : {
                StudentRegistration();
                break;
            }
            case 3 : {
                Menu();
                break;
            }
            default : {
                Console.WriteLine(" Sorry please selected type again.");
                Console.ReadLine();
                RegistrationMenu();
                break;
            }
        }
    }

    static void PersonnelRegistration(){
        Console.Clear();
        Console.WriteLine(" Personnel register ");
        Console.WriteLine("---------------------------------------------------");
        string title = SelectedTitle();
        string name = InputName();
        string surname = InputSurName();

        if(personList.CheckedName(title, name, surname)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("This name has already registed. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            PersonnelRegistration();
            return;
        }

        string email = InputEmail();

        if(personList.CheckedEmail(email)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("This email has already registed. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            PersonnelRegistration();
            return;
        }

        string username = InputUserName();
        string password = InputPassword();

        if(personList.CheckedLogin(username, password)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("registration error the username or password is invalid. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            PersonnelRegistration();
            return;
        }


        Personnel personnel = new Personnel(title, name, surname, email, username, password);
        Program.personList.AddPerson(personnel);

        SucceedRegister1();
    }

    static void StudentRegistration(){
        Console.Clear();
        Console.WriteLine(" Student register ");
        Console.WriteLine("---------------------------------------------------");
        string title = SelectedTitle();
        string name = InputName();
        string surname = InputSurName();

        if(personList.CheckedName(title, name, surname)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("This name has already registed. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            StudentRegistration();
            return;
        }

        string email = InputEmail();

        if(personList.CheckedEmail(email)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("This email has already registed. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            StudentRegistration();
            return;
        }

        string username = InputUserName();
        string password = InputPassword();

        if(personList.CheckedLogin(username, password)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("registration error the username or password is invalid. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            StudentRegistration();
            return;
        }

        Student student = new Student(title, name, surname, email, username, password);
        Program.personList.AddPerson(student);

        SucceedRegister2();
    }
    //------------------------------------------------------------------------------------------------------------------

    //---------------------------------------------------Succeed Register-----------------------------------------------
    static void SucceedRegister1(){
        Console.Clear();
        SucceedRegisterMenu();
        SelectedSucceedRegistrationMenu1();
    }

    static void SucceedRegister2(){
        Console.Clear();
        SucceedRegisterMenu();
        SelectedSucceedRegistrationMenu2();
    }

    static void SucceedRegisterMenu(){
        Console.WriteLine(" Successful registration. ");
        Console.WriteLine("------------- What do you want to do? -------------");
        Console.WriteLine(" 1.Stay login");
        Console.WriteLine(" 2.Log out");
        Console.WriteLine(" 3.Exit");
        Console.WriteLine("---------------------------------------------------");
    }

    static void SelectedSucceedRegistrationMenu1(){
        Console.Write(" Please input selected Menu : ");

        int sr = int.Parse(Console.ReadLine());
        switch (sr){
            case 1 : {
                PersonnelScreen();
                break;
            }
            case 2 : {
                Menu();
                break;
            }
            case 3 : break;
            default : {
                Console.WriteLine(" Sorry please selected Menu again.");
                Console.ReadLine();
                SelectedSucceedRegistrationMenu1();
                break;
            }
        }        
    }

    static void SelectedSucceedRegistrationMenu2(){
        Console.Write(" Please input selected Menu : ");

        int sr = int.Parse(Console.ReadLine());
        switch (sr){
            case 1 : {
                StudentScreen();
                break;
            }
            case 2 : {
                Menu();
                break;
            }
            case 3 : break;
            default : {
                Console.WriteLine(" Sorry please selected Menu again.");
                Console.ReadLine();
                SelectedSucceedRegistrationMenu2();
                break;
            }
        }        
    }

    //------------------------------------------------------------------------------------------------------------------

    //---------------------------------------------------Login----------------------------------------------------------
    static void LoginMenu(){
        Console.Clear();
        Login();
    }

    static void Login(){
        string username = InputUserName();
        string password = InputPassword();

        if(personList.CheckedLogin(username, password)){
            if(personList.CheckedStatus()){
                PersonnelScreen();
            }
            else{
                StudentScreen();
            }
        }
        else{
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("The username or password is invalid. please try again.");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            Menu();
            return;
        }
    }
    //------------------------------------------------------------------------------------------------------------------

    //---------------------------------------------------Succeed Login----------------------------------------------------
    static void PersonnelScreen(){
        Console.Clear();
        SucceedLoginMenu();
        SelectedSucceedLoginMenu();
    }

    static void StudentScreen(){
        Console.Clear();
        SucceedLoginMenu();
        SelectedSucceedLoginMenu();
    }

    static void SucceedLoginMenu(){
        Console.WriteLine("Welcome.");
        Console.WriteLine("------------- What do you want to do? -------------");
        Console.WriteLine(" 1.Log out");
        Console.WriteLine(" 2.Exit");
        Console.WriteLine("---------------------------------------------------");
    }

    static void SelectedSucceedLoginMenu(){
        Console.Write(" Please input selected Menu : ");

        int sr = int.Parse(Console.ReadLine());
        switch (sr){
            case 1 : {
                Menu();
                break;
            }
            case 2 : break;
            default : {
                Console.WriteLine(" Sorry please selected Menu again.");
                Console.ReadLine();
                SelectedSucceedLoginMenu();
                break;
            }
        }        
    }
    //------------------------------------------------------------------------------------------------------------------

    //---------------------------------------------------Guest Login----------------------------------------------------
    static void GuestLoginMenu(){
        Console.Clear();
        string title = SelectedTitle();
        string name = InputName();
        string surname = InputSurName();
        string email = InputEmail();
        Console.Clear();
        SucceedLoginMenu();
        SelectedSucceedLoginMenu();
    }
    //------------------------------------------------------------------------------------------------------------------

    //---------------------------------------------------Input Data-----------------------------------------------------
    static string SelectedTitle(){
        Console.Write(" Please select your title ");
        Console.Write(" 1. Mr.");
        Console.Write(" 2. Ms.");
        Console.Write(" 3. Mrs. :");

        int t = int.Parse(Console.ReadLine());
        switch(t){
            case 1 : return "Mr.";
            case 2 : return "Ms.";
            case 3 : return "Mrs.";
            default : {
                Console.WriteLine(" Sorry please select title again.");
                return SelectedTitle();
            }
        }
    }

    static string InputName(){
        Console.Write(" Please input your name : ");
        return Console.ReadLine();
    }

    static string InputSurName(){
        Console.Write(" Please input your surname : ");
        return Console.ReadLine();
    }

    static string InputEmail(){
        Console.Write(" Please input your email : ");
        return Console.ReadLine();
    }

    static string InputUserName(){
        Console.Write(" Please input username : ");
        return Console.ReadLine();
    }

    static string InputPassword(){
        Console.Write(" Please input your password : ");
        return Console.ReadLine();
    }
    //------------------------------------------------------------------------------------------------------------------
}

