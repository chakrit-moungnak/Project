class All_login{
    static PersonList personList = new PersonList();
    static Menu_all menu_All = new Menu_all();
    static Get_Set_ticket ticket = new Get_Set_ticket();
    static Bus_station bus_Station = new Bus_station();
    public void start_main_menu(){
        Menu();
    }
    private static void Menu(){
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

        int m;
        int.TryParse(Console.ReadLine(),out m);
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
            case 4 : 
                Console.Clear();
                Console.WriteLine("__________________________________");
                Console.WriteLine("Thank You to use my Program \n See you next time");
                Console.WriteLine("__________________________________");   
                Console.ReadLine(); 
                break;            
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
        Console.WriteLine(" 1.Admin");
        Console.WriteLine(" 2.User");
        Console.WriteLine(" 3.Back");
        Console.WriteLine("---------------------------------------------------");
    }
    
    static void SelectedRegistrationMenu(){
        Console.Write(" Please input selected type : ");

        int r;
        int.TryParse(Console.ReadLine(),out r);
        switch (r){
            case 1 : {
                AdminRegistration();
                break;
            }
            case 2 : {
                UserRegistration();
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

    static void AdminRegistration(){
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
            AdminRegistration();
            return;
        }

        string email = InputEmail();

        if(personList.CheckedEmail(email)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("This email has already registed. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            AdminRegistration();
            return;
        }

        string username = InputUserName();
        string password = InputPassword();

        if(personList.CheckedLogin(username, password)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("registration error the username or password is invalid. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            AdminRegistration();
            return;
        }
        string admin_confirm = "y";
        Admin admin = new Admin(title, name, surname, email, username, password,admin_confirm);
        personList.AddPerson(admin);

        SucceedRegister1();
    }

    static void UserRegistration(){
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
            UserRegistration();
            return;
        }

        string email = InputEmail();

        if(personList.CheckedEmail(email)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("This email has already registed. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            UserRegistration();
            return;
        }

        string username = InputUserName();
        string password = InputPassword();

        if(personList.CheckedLogin(username, password)){
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("registration error the username or password is invalid. please try again. ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            UserRegistration();
            return;
        }
        string user_confirm = "x";
        User user = new User(title, name, surname, email, username, password,user_confirm);
        personList.AddPerson(user);

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

        int sr;
        int.TryParse(Console.ReadLine(),out sr);
        switch (sr){
            case 1 : {
                Console.Clear();
                menu_All.PrintAdminMenu(ticket,bus_Station);
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

        int sr;
        int.TryParse(Console.ReadLine(),out sr);
        switch (sr){
            case 1 : {
                UserScreen();
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
        personList.set_admin(username, password);
        if(personList.CheckedLogin(username, password)){
            if(personList.get_admin() == true){
                AdminScreen();
            }
            else{
                UserScreen();
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
    static void AdminScreen(){
        Console.Clear();
        menu_All.PrintAdminMenu(ticket,bus_Station);
    }

    static void UserScreen(){
        Console.Clear();
        menu_All.PrintMainMenu(ticket,bus_Station);
    }

    //---------------------------------------------------Guest Login----------------------------------------------------
    static void GuestLoginMenu(){
        Console.Clear();
        string title = SelectedTitle();
        string name = InputName();
        string surname = InputSurName();
        string email = InputEmail();
        Console.Clear();
        menu_All.PrintMainMenu(ticket,bus_Station);
    }
    //------------------------------------------------------------------------------------------------------------------

    //---------------------------------------------------Input Data-----------------------------------------------------
    static string SelectedTitle(){
        Console.Write(" Please select your title ");
        Console.Write(" 1. Mr.");
        Console.Write(" 2. Ms.");
        Console.Write(" 3. Mrs. :");

        int t;
        int.TryParse(Console.ReadLine(),out t);
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
    static string Input_Admin(){
        return Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------------------------------
}