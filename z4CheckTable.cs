class Check_table{
    Menu_all menu_All = new Menu_all();
    bus_schedule bus_Schedule = new bus_schedule();
    Bus_station bus_Station = new Bus_station();
    public void Table_Ticket_menu(Get_Set_ticket ticket){
        Console.WriteLine("_____________________________");
        Console.WriteLine("*Today's schedule*");
        List<double> modkun = new List<double>();
        List<double> kunmod = new List<double>();
        int i=0;
        Console.WriteLine("BangMod--->BangKhun");
        foreach(double mod in modkun){
            i++;
            Console.WriteLine("{0}---[{1:F2}]",i,mod);
        }
        bus_Station.set_start_Mod_To_Khun();
        bus_Station.next_bus_start_mod_to_kun();        
        i=0;
        Console.WriteLine("BangKhun--->BangMod");
        foreach(double mod in kunmod){
            i++;
            Console.WriteLine("{0}---[{1:F2}]",i,mod);
        }
        bus_Station.set_start_Khun_To_Mod();
        bus_Station.next_bus_start_kun_to_mod();
        Console.WriteLine("*remaining seats Bangmod To Bangkhuntain {0}/25*",ticket.get_ticket_Mod_To_Khun());
        Console.WriteLine("*remaining seats Bangkhuntain To Bangmod {0}/25*",ticket.get_ticket_Khun_To_Mod());
        Console.WriteLine("*Check did you booking_______*");
        Console.WriteLine("-------------Menu-------------");
        Console.WriteLine("*Back pls input [anything]*");
        Console.WriteLine("______________________________");
        Console.ReadLine();
        Console.Clear();
        menu_All.PrintMainMenu(ticket);
    }

    public void Table_Ticket_menu_Admin(Get_Set_ticket ticket){
        Console.WriteLine("_____________________________");
        Console.WriteLine("*Today's schedule*");
        List<double> modkun = new List<double>();
        List<double> kunmod = new List<double>();
        modkun = bus_Schedule.bus_schedule_Mod_To_Kun();
        kunmod = bus_Schedule.bus_schedule_Kun_To_Mod();
        int i=0;
        Console.WriteLine("BangMod--->BangKhun");
        foreach(double mod in modkun){
            i++;
            Console.WriteLine("{0}---[{1:F2}]",i,mod);
        }
        bus_Station.set_start_Mod_To_Khun();
        bus_Station.next_bus_start_mod_to_kun();
        i=0;
        Console.WriteLine("BangKhun--->BangMod");
        foreach(double mod in kunmod){
            i++;
            Console.WriteLine("{0}---[{1:F2}]",i,mod);
        }
        bus_Station.set_start_Khun_To_Mod();
        bus_Station.next_bus_start_kun_to_mod();
        Console.WriteLine("*remaining seats Bangmod To Bangkhuntain {0}/25*",ticket.get_ticket_Mod_To_Khun());
        Console.WriteLine("*remaining seats Bangkhuntain To Bangmod {0}/25*",ticket.get_ticket_Khun_To_Mod());
        Console.WriteLine("*Check did you booking_______*");
        Console.WriteLine("-------------Menu-------------");
        Console.WriteLine("*Back pls input [anything]*");
        Console.WriteLine("______________________________");
        Console.ReadLine();
        Console.Clear();
        menu_All.PrintAdminMenu(ticket);
    }
}