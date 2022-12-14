class Booking_Menu{
    static Menu_all menu_All = new Menu_all();
    private string booking_check;
    private void set_booking_check(){
        this.booking_check = Console.ReadLine();
    }
    //----------------------------------------------------------------------------------
    public void Book_Menu(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.WriteLine("______________________________");
        Console.WriteLine("*-Time*");              //ตารางเวลา----
        Console.WriteLine("*--------Book_Ticket---------*");
        Console.WriteLine("*1.KMUTT --> Bang Khun Thian *");
        Console.WriteLine("*2.Bang Khun Thian --> KMUTT *");
        Console.WriteLine("*3.Back to Bus Ticket Booking*");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_booking_check();
        switch(booking_check) 
        {
            case "1":
                Console.Clear();
                Menu_Mod_To_Khun(ticket,bus_Station);
                break;
            case "2":
                Console.Clear();
                Menu_Khun_To_Mod(ticket,bus_Station);
                break;
            case "3":
                Console.Clear();
                menu_All.PrintMainMenu(ticket,bus_Station);
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                Console.Clear();
                Book_Menu(ticket,bus_Station);
                break;
        }
    }
    //--------------------------------------------------------------------------------
    public void Menu_Khun_To_Mod(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.Clear();      
        Console.WriteLine("______________________________");
        Console.WriteLine("*Time----*");
        Console.WriteLine("*remaining seats {0}/25*",ticket.get_ticket_Khun_To_Mod());
        Console.WriteLine("*--------Book_Ticket----------*");
        Console.WriteLine("*--KMUTT --> Bang Khun Thian--*");
        Console.WriteLine("*Get Ticket please input [Y]");
        Console.WriteLine("*Cancle Ticket please input [C]");
        Console.WriteLine("*Enter To Get Back*");
        Console.WriteLine("______________________________");
        Console.Write("Please in put here : ");
        ticket.set_Khun_To_Mod();
        set_booking_check();
        switch(booking_check){
            case "Y":
                ticket.increase_ticket();
                break;
            case "y":
                ticket.increase_ticket();
                break;
            case "C":
                ticket.decrease_ticket();
                break;
            case "c":
                ticket.decrease_ticket();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                break;
        }
    Console.Clear();
    Book_Menu(ticket,bus_Station);
    }
    public void Menu_Mod_To_Khun(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.Clear();      
        Console.WriteLine("______________________________");
        Console.WriteLine("*Time----*");
        Console.WriteLine("*remaining seats {0}/25*",ticket.get_ticket_Mod_To_Khun());
        Console.WriteLine("*--------Book_Ticket----------*");
        Console.WriteLine("*--KMUTT --> Bang Khun Thian--*");
        Console.WriteLine("*Get Ticket please input [Y]");
        Console.WriteLine("*Cancle Ticket please input [C]");
        Console.WriteLine("*Enter To Get Back*");
        Console.WriteLine("______________________________");
        Console.Write("Please in put here : ");
        ticket.set_Mod_To_Khun();
        set_booking_check();
        switch(booking_check){
            case "Y":
                ticket.increase_ticket();
                break;
            case "y":
                ticket.increase_ticket();
                break;
            case "C":
                ticket.decrease_ticket();
                break;
            case "c":
                ticket.decrease_ticket();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                break;
        }
    Console.Clear();
    Book_Menu(ticket,bus_Station);
    }

    public void Admin_Bus_Menu_Mod_To_Khun(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.WriteLine("______________________________");
        Console.WriteLine("Release bus Input = Y");
        Console.WriteLine("Enter to Back");
        Console.WriteLine("______________________________");
        Console.WriteLine("Input your menu");
        ticket.set_Mod_To_Khun();
        set_booking_check();
        switch(booking_check){
            case "Y":
                bus_Station.set_Time_modkun();
                Console.WriteLine("Bus is start at {0:F2}",bus_Station.get_start_now_Mod_Kun());
                Console.ReadLine();
                ticket.reset_ticket_Mod_To_Khun();
                break;
            case "y":
                bus_Station.set_Time_modkun();
                Console.WriteLine("Bus is start at {0:F2}",bus_Station.get_start_now_Mod_Kun());
                Console.ReadLine();
                ticket.reset_ticket_Mod_To_Khun();
                break;
            default : 
                break;
        }
    Console.Clear();
    menu_All.PrintAdminMenu(ticket,bus_Station);
    }

    public void Admin_Bus_Menu_Khun_To_Mod(Get_Set_ticket ticket,Bus_station bus_Station){
        Console.WriteLine("______________________________");
        Console.WriteLine("Release bus Input = Y");
        Console.WriteLine("Enter to Back");
        Console.WriteLine("______________________________");
        Console.WriteLine("Input your menu");
        ticket.set_Khun_To_Mod();
        set_booking_check();
        switch(booking_check){
            case "Y":
                bus_Station.set_Time_kunmod();
                Console.WriteLine("Bus is start at {0:F2}",bus_Station.get_start_now_Kun_Mod());
                Console.ReadLine();
                ticket.reset_ticket_Khun_To_Mod();
                break;
            case "y":
                bus_Station.set_Time_kunmod();
                Console.WriteLine("Bus is start at {0:F2}",bus_Station.get_start_now_Kun_Mod());
                Console.ReadLine();
                ticket.reset_ticket_Khun_To_Mod();
                break;
            default : 
                break;
        }
    Console.Clear();
    menu_All.PrintAdminMenu(ticket,bus_Station);
    }
}
