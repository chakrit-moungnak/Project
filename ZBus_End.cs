class End_Report {
    Menu_all menu_All = new Menu_all();
    private bool bus_End_Mod_To_Khun = false;
    private bool bus_End_Khun_To_Mod = false;
    private double Bus_End_at_Mod_Kun;
    private double Bus_End_at_Kun_Mod;
    private double time_modkun;
    private double time_kunmod;
    private void set_end_Mod_To_Khun(){
        this.bus_End_Mod_To_Khun = true;
    }
    private void set_end_Khun_To_Mod(){
        this.bus_End_Khun_To_Mod = true;
    }
    private double get_time_modkun(){
        return this.time_modkun;
    }
    private double get_time_kunmod(){
        return this.time_kunmod;
    }
    private void set_time_end(){
        today today = new today();
        if (bus_End_Mod_To_Khun == true){
            double b = today.get_this_minute();
            this.Bus_End_at_Mod_Kun = today.get_this_hour()+b/100;
        }
        if (bus_End_Khun_To_Mod == true){
            double b = today.get_this_minute();
            this.Bus_End_at_Kun_Mod = today.get_this_hour()+b/100;
        }
    }
    private void Calculate_Time(Bus_station bus_Station){
        set_time_end();
        if (bus_End_Mod_To_Khun == true){
            double bus_start = bus_Station.get_start_now_Mod_Kun();
            this.time_modkun = Minute_Calculate(Bus_End_at_Mod_Kun)-Minute_Calculate(bus_start);
            this.bus_End_Mod_To_Khun = false;
        }   
        if (bus_End_Khun_To_Mod == true){
            double bus_start = bus_Station.get_start_now_Kun_Mod();
            this.time_modkun = Minute_Calculate(Bus_End_at_Kun_Mod)-Minute_Calculate(bus_start);
            this.bus_End_Khun_To_Mod = false;
        }
    }
    private double Minute_Calculate(double time){
        double time_hour_to_minute = Math.Floor(time)*60;
        double minute = (time-Math.Floor(time))*100;
        time = time_hour_to_minute+minute;
        return time;
    }

    public void End_Bus_to_set_time_modkun(Get_Set_ticket ticket,Bus_station bus_Station){
        set_end_Mod_To_Khun();
        Calculate_Time(bus_Station);
        Console.WriteLine("________________________");
        Console.WriteLine("Bus is arrives at {0:F2}",this.Bus_End_at_Mod_Kun);
        if (time_modkun >= 60){
            time_modkun = time_modkun/60;
            Console.WriteLine("Using time {0:F2} Hour",time_modkun);
        }
        else Console.WriteLine("Using time {0} minute",Math.Floor(time_modkun));
        Console.WriteLine("________________________");
        Console.WriteLine("Enter to Back");
        Console.ReadLine();
        menu_All.PrintAdminMenu(ticket,bus_Station);
    }
    public void End_Bus_to_set_time_kunmod(Get_Set_ticket ticket,Bus_station bus_Station){
        set_end_Khun_To_Mod();
        Calculate_Time(bus_Station);
        Console.WriteLine("________________________");
        Console.WriteLine("Bus is arrives at {0:F2}",this.Bus_End_at_Kun_Mod);
        if (time_kunmod >= 60){
            time_kunmod = time_kunmod/60;
            Console.WriteLine("Using time {0:F2} Hour",time_kunmod);
        }
        else Console.WriteLine("Using time {0} minute",Math.Floor(time_kunmod));
        Console.WriteLine("________________________");
        Console.WriteLine("Enter to Back");
        Console.ReadLine();
        menu_All.PrintAdminMenu(ticket,bus_Station);
    }
}