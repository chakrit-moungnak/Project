class Menu_all{
    static Booking_Menu booking_Menu = new Booking_Menu();
    static Check_table check_Table = new Check_table();
    static All_login all_Login = new All_login();
    static PersonList personList = new PersonList();
    static Driver_ploblem driver_Ploblem = new Driver_ploblem();
    private int Menu_check=0;

    public void set_menucheck(){
        int check;
        int.TryParse(Console.ReadLine(),out check);
        this.Menu_check = check;
    }
    private void reset_Menu_check(){
        this.Menu_check =0;
    }
    public void PrintAdminMenu(Get_Set_ticket ticket){
        personList.reset_status_admin();
        Console.WriteLine("______________________________");
        Console.WriteLine("------Bus Ticket Booking----------");
        Console.WriteLine("1.Checking"); //ตารางเวลาวันนี้ รอบรถที่ จำนวนที่นั่ง  ?/25<0-24>  
        Console.WriteLine("2.Release Bus");  //แสดงรอบรถปัจจุบัน จำนวนที่นั่ง  errorจากเเอด   เลือกให้จอด
        Console.WriteLine("3.Ploblem Anouncment");
        Console.WriteLine("4.Logout");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_menucheck();
        switch(Menu_check) 
        {
            case 1:
                Console.Clear();
                check_Table.Table_Ticket_menu_Admin(ticket);
                break;
            case 2:
                Console.Clear();
                release_bus_menu(ticket);
                break;
            case 3:
                Console.Clear();
                Input_Driver_problem(ticket);
                break;
            case 4:
                Console.Clear();
                all_Login.start_main_menu();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                Console.Clear();
                PrintAdminMenu(ticket);
                break;
        }
    }
    public void release_bus_menu(Get_Set_ticket ticket){
        Console.WriteLine("______________________________");
        Console.WriteLine("1.BangMod To BangKhuntain");
        Console.WriteLine("2.BangKhuntain To BangMod");
        Console.WriteLine("3.Back Input anything");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_menucheck();
        switch(Menu_check) 
        {
            case 1:
                Console.Clear();
                booking_Menu.Admin_Bus_Menu_Mod_To_Khun(ticket);
                break;
            case 2:
                Console.Clear();
                booking_Menu.Admin_Bus_Menu_Khun_To_Mod(ticket);
                break;
            default: 
                break;
        }
        Console.Clear();
        PrintAdminMenu(ticket);
    }


    public void PrintMainMenu(Get_Set_ticket ticket) {
        personList.reset_status_admin();
        Console.WriteLine("______________________________");
        Console.WriteLine("------Bus Ticket Booking----------");
        Console.WriteLine("1.Checking"); //ตารางเวลาวันนี้ รอบรถที่ จำนวนที่นั่ง  ?/25<0-24>  
        Console.WriteLine("2.Booking");  //แสดงรอบรถปัจจุบัน จำนวนที่นั่ง  errorจากเเอด   เลือกให้จอด
        Console.WriteLine("3.Logout");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_menucheck();
        switch(Menu_check) 
        {
            case 1:
                Console.Clear();
                if (driver_Ploblem.get_problem_check() == true){
                    Show_Driver_ploblem(ticket);
                }
                check_Table.Table_Ticket_menu(ticket);
                break;
            case 2:
                Console.Clear();        
                if (driver_Ploblem.get_problem_check() == true){
                    Show_Driver_ploblem(ticket);
                }
                booking_Menu.Book_Menu(ticket);
                break;
            case 3:
                Console.Clear();
                all_Login.start_main_menu();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                Console.Clear();
                PrintMainMenu(ticket);
                break;
        }
    }
    public void Input_Driver_problem(Get_Set_ticket ticket){
        Console.WriteLine("______________________________");
        Console.WriteLine("Input 1 To report a problem");
        Console.WriteLine("Input 2 Cancel Report");
        Console.WriteLine("Input any thing to Back");
        Console.WriteLine("______________________________");
        Console.WriteLine("Input Your Menu");
        set_menucheck();
        switch(Menu_check) 
        {
            case 1:
                driver_Ploblem.set_Driver_ploblem();
                Console.WriteLine("We will announcement to user now");
                Console.ReadLine();
                PrintAdminMenu(ticket);
                break;
            case 2:
                driver_Ploblem.re_problem_check();
                Console.WriteLine("Problem is gone");
                Console.ReadLine();
                PrintAdminMenu(ticket);
                break;
        }
        Console.Clear();
        PrintAdminMenu(ticket);
    }

    public void Show_Driver_ploblem(Get_Set_ticket ticket){
        Console.WriteLine("______________________________");
        Console.WriteLine("NOW HAVE A PROBLEM {0}",driver_Ploblem.get_Driver_ploblem());
        Console.WriteLine("At {0}",driver_Ploblem.get_time_driver_problem());
        Console.WriteLine("______________________________");
        Console.ReadLine();
        PrintMainMenu(ticket);
    }   
}