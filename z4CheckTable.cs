class Check_table{
    Menu_all menu_All = new Menu_all();
    bus_schedule bus_Schedule = new bus_schedule();
    public void Table_Ticket_menu(Get_Set_ticket ticket,Bus_station bus_Station){
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
        bus_Station.next_bus_table_mod_to_kun();
        i=0;
        Console.WriteLine("BangKhun--->BangMod");
        foreach(double mod in kunmod){
            i++;
            Console.WriteLine("{0}---[{1:F2}]",i,mod);
        }
        bus_Station.next_bus_table_kun_to_mod();
        Console.WriteLine("*remaining seats Bangmod To Bangkhuntain {0}/25*",ticket.get_ticket_Mod_To_Khun());
        Console.WriteLine("*remaining seats Bangkhuntain To Bangmod {0}/25*",ticket.get_ticket_Khun_To_Mod());
        Console.WriteLine("*Check did you booking_______*");
        Console.WriteLine("-------------Menu-------------");
        Console.WriteLine("*Enter To Get Back*");
        Console.WriteLine("______________________________");
        Console.ReadLine();
        Console.Clear();
        menu_All.PrintMainMenu(ticket,bus_Station);
    }

    public void Table_Ticket_menu_Admin(Get_Set_ticket ticket,Bus_station bus_Station){
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
        bus_Station.next_bus_table_mod_to_kun();
        i=0;
        Console.WriteLine("BangKhun--->BangMod");
        foreach(double mod in kunmod){
            i++;
            Console.WriteLine("{0}---[{1:F2}]",i,mod);
        }
        bus_Station.next_bus_table_kun_to_mod();
        Console.WriteLine("*remaining seats Bangmod To Bangkhuntain {0}/25*",ticket.get_ticket_Mod_To_Khun());
        Console.WriteLine("*remaining seats Bangkhuntain To Bangmod {0}/25*",ticket.get_ticket_Khun_To_Mod());
        Console.WriteLine("*Check did you booking_______*");
        Console.WriteLine("-------------Menu-------------");
        Console.WriteLine("*Back pls input [anything]*");
        Console.WriteLine("______________________________");
        Console.ReadLine();
        Console.Clear();
        menu_All.PrintAdminMenu(ticket,bus_Station);
    }
}