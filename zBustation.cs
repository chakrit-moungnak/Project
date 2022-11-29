class Bus_station{
    today today1 = new today();
    private bool bus_start_Mod_To_Khun = false;
    private bool bus_start_Khun_To_Mod = false;
    private double Bus_start_at_Mod_Kun;
    private double Bus_start_at_Kun_Mod;
    private double time_for_table_modkun;
    private double time_for_table_kunmod;
    private void set_time_table(){
        today today = new today();
            double a = today.get_this_minute();
            this.time_for_table_modkun = today.get_this_hour()+a/100;
            double b = today.get_this_minute();
            this.time_for_table_kunmod = today.get_this_hour()+b/100;
    }
    public void next_bus_table_mod_to_kun(){
        set_time_table();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Mod_To_Kun();
        int i=0,bus_out_check=0;
        foreach(double bus_time in bustime){
            if (time_for_table_modkun<bus_time){
                Console.WriteLine("Next start is {0:F2}",bustime[i]);
                bus_out_check =1;
                break;
            }
        i++;
        }
        if (bus_out_check == 0){
                Console.WriteLine("Bus is out");
        }
    }
    public void next_bus_table_kun_to_mod(){
        set_time_table();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Kun_To_Mod();
        int i=0,bus_out_check=0;
        foreach(double bus_time in bustime){
            if (time_for_table_kunmod<bus_time){
                Console.WriteLine("Next start is {0:F2}",bustime[i]);
                bus_out_check =1;
                break;
            }
        i++;
        }
        if (bus_out_check == 0){
            Console.WriteLine("Bus is out");
        }
    }
    

    private void setMod_To_Khun(){
        this.bus_start_Mod_To_Khun = true;
    }
    private void setKhun_To_Mod(){
        this.bus_start_Khun_To_Mod = true;
    }
    public double get_start_now_Mod_Kun(){
        return this.Bus_start_at_Mod_Kun;
    }
    public double get_start_now_Kun_Mod(){
        return this.Bus_start_at_Kun_Mod;
    }
    public void set_Time_modkun(){
        setMod_To_Khun();
        set_time_start();
    }
    public void set_Time_kunmod(){
        setKhun_To_Mod();
        set_time_start();
    }
    private void set_time_start(){
        today today = new today();
        if (bus_start_Mod_To_Khun == true){
            double b = today.get_this_minute();
            this.Bus_start_at_Mod_Kun = today.get_this_hour()+b/100;
            this.bus_start_Mod_To_Khun = false;
        }
        if (bus_start_Khun_To_Mod == true){
            double b = today.get_this_minute();
            this.Bus_start_at_Kun_Mod = today.get_this_hour()+b/100;
            this.bus_start_Khun_To_Mod = false;
        }
    }
    public void next_bus_start_mod_to_kun(){
        set_time_start();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Mod_To_Kun();
        int i=0,bus_out_check=0;
        foreach(double bus_time in bustime){
            if (Bus_start_at_Mod_Kun<bus_time){
                Console.WriteLine("Next start is {0:F2}",bustime[i]);
                bus_out_check =1;
                break;
            }
        i++;
        }
        if (bus_out_check == 0){
                Console.WriteLine("Bus is out");
        }
    }
    public void next_bus_start_kun_to_mod(){
        set_time_start();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Kun_To_Mod();
        int i=0,bus_out_check=0;
        foreach(double bus_time in bustime){
            if (Bus_start_at_Kun_Mod<bus_time){
                Console.WriteLine("Next start is {0:F2}",bustime[i]);
                bus_out_check =1;
                break;
            }
        i++;
        }
        if (bus_out_check == 0){
            Console.WriteLine("Bus is out");
        }
    }
}