class Menu_all{
    static Booking_Menu booking_Menu = new Booking_Menu();
    static Check_table check_Table = new Check_table();
    static All_login all_Login = new All_login();
    static PersonList personList = new PersonList();
    static Driver_ploblem driver_Ploblem = new Driver_ploblem();
    static End_Report end_Report = new End_Report();
    private int Menu_check=0;

    public void set_menucheck(){
        int check;
        int.TryParse(Console.ReadLine(),out check);
        this.Menu_check = check;
    }
    private void reset_Menu_check(){
        this.Menu_check =0;
    }
    public void PrintAdminMenu(Get_Set_ticket ticket,Bus_station bus_Station){
        personList.reset_status_admin();
        Console.WriteLine("______________________________");
        Console.WriteLine("------Bus Ticket Booking----------");
        Console.WriteLine("1.Checking"); //ตารางเวลาวันนี้ รอบรถที่ จำนวนที่นั่ง  ?/25<0-24>  
        Console.WriteLine("2.Release Bus");  //แสดงรอบรถปัจจุบัน จำนวนที่นั่ง  errorจากเเอด   เลือกให้จอด
        Console.WriteLine("3.End Bus");
        Console.WriteLine("4.Ploblem Anouncment");
        Console.WriteLine("5.Logout");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_menucheck();
        switch(Menu_check) 
        {
            case 1:
                Console.Clear();
                check_Table.Table_Ticket_menu_Admin(ticket,bus_Station);
                break;
            case 2:
                Console.Clear();
                release_bus_menu(ticket,bus_Station);
                break;
            case 3:
                Console.Clear();
                Bus_End_Menu(ticket,bus_Station);
                break;
            case 4:
                Console.Clear();
                Input_Driver_problem(ticket,bus_Station);
                break;
            case 5:
                Console.Clear();
                all_Login.start_main_menu();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                Console.Clear();
                PrintAdminMenu(ticket,bus_Station);
                break;
        }
    }
    public void release_bus_menu(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.WriteLine("______________________________");
        Console.WriteLine("1.BangMod To BangKhuntain");
        Console.WriteLine("2.BangKhuntain To BangMod");
        Console.WriteLine("Enter to Back");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_menucheck();
        switch(Menu_check) 
        {
            case 1:
                Console.Clear();
                booking_Menu.Admin_Bus_Menu_Mod_To_Khun(ticket,bus_Station);
                break;
            case 2:
                Console.Clear();
                booking_Menu.Admin_Bus_Menu_Khun_To_Mod(ticket,bus_Station);
                break;
            default: 
                break;
        }
        Console.Clear();
        PrintAdminMenu(ticket,bus_Station);
    }
    public void Bus_End_Menu(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.WriteLine("______________________________");
        Console.WriteLine("1.BangMod To BangKhuntain");
        Console.WriteLine("2.BangKhuntain To BangMod");
        Console.WriteLine("3.Enter to Back");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_menucheck();
        Console.Clear();
        switch(Menu_check) 
        {
            case 1:
                end_Report.End_Bus_to_set_time_modkun(ticket,bus_Station);
                break;
            case 2:
                end_Report.End_Bus_to_set_time_kunmod(ticket,bus_Station);
                break;
            default: 
                break;
        }
        PrintAdminMenu(ticket,bus_Station);
    }


    public void PrintMainMenu(Get_Set_ticket ticket,Bus_station bus_Station) {
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
                    Show_Driver_ploblem(ticket,bus_Station);
                }
                check_Table.Table_Ticket_menu(ticket,bus_Station);
                break;
            case 2:
                Console.Clear();        
                if (driver_Ploblem.get_problem_check() == true){
                    Show_Driver_ploblem(ticket,bus_Station);
                }
                booking_Menu.Book_Menu(ticket,bus_Station);
                break;
            case 3:
                Console.Clear();
                all_Login.start_main_menu();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                Console.Clear();
                PrintMainMenu(ticket,bus_Station);
                break;
        }
    }
    public void Input_Driver_problem(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.WriteLine("______________________________");
        Console.WriteLine("Input 1 To report a problem");
        Console.WriteLine("Input 2 Cancel Report");
        Console.WriteLine("*Enter To Get Back*");
        Console.WriteLine("______________________________");
        Console.WriteLine("Input Your Menu");
        set_menucheck();
        Console.Clear();
        switch(Menu_check) 
        {
            case 1:
                Console.WriteLine("*Please in put problem*");
                driver_Ploblem.set_Driver_ploblem();
                Console.WriteLine("We will announcement to user now");
                Console.WriteLine("*Enter To Get Back*");
                Console.ReadLine();
                Console.Clear();
                PrintAdminMenu(ticket,bus_Station);
                break;
            case 2:
                driver_Ploblem.re_problem_check();
                Console.WriteLine("Problem is gone");
                Console.WriteLine("*Enter To Get Back*");
                Console.ReadLine();
                Console.Clear();
                PrintAdminMenu(ticket,bus_Station);
                break;
        }
        Console.Clear();
        PrintAdminMenu(ticket,bus_Station);
    }

    public void Show_Driver_ploblem(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.WriteLine("______________________________");
        Console.WriteLine("NOW HAVE A PROBLEM {0}",driver_Ploblem.get_Driver_ploblem());
        Console.WriteLine("At {0}",driver_Ploblem.get_time_driver_problem());
        Console.WriteLine("*Enter To Get Back*");
        Console.WriteLine("______________________________");
        Console.ReadLine();
        PrintMainMenu(ticket,bus_Station);
    }   
}