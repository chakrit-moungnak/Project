class Bus_station{
    private bool bus_start_Mod_To_Khun = false;
    private bool bus_start_Khun_To_Mod = false;
    private double Bus_start_at_Mod_Kun;
    private double Bus_start_at_Kun_Mod;

    private string bus_start_at_Mod_Kun;
    private string bus_start_at_Kun_Mod;
    public void set_start_Mod_To_Khun(){
        this.bus_start_Mod_To_Khun = true;
    }
    public void set_start_Khun_To_Mod(){
        this.bus_start_Khun_To_Mod = true;
    }
    public string get_start_now_Mod_Kun(){
        return this.bus_start_at_Mod_Kun;
    }
    public string get_start_now_Kun_Mod(){
        return this.bus_start_at_Kun_Mod;
    }
    private void bus_start_time_Mod_To_Khun(){
        if(this.bus_start_Mod_To_Khun == true){
            today today = new today();
            int bus_start_hour = today.get_this_hour();
            int bus_start_minute = today.get_this_minute();
            this.Bus_start_at_Mod_Kun = bus_start_hour*100+bus_start_minute;
            string bus_start_at = (bus_start_hour+"."+bus_start_minute);
        }
        else {
            Console.WriteLine("Bus is out");
        }
    }
    private void bus_start_time_Khun_To_Mod(){
        if(this.bus_start_Khun_To_Mod == true){
            today today = new today();
            int bus_start_hour = today.get_this_hour();
            int bus_start_minute = today.get_this_minute();
            this.Bus_start_at_Kun_Mod = bus_start_hour*100+bus_start_minute;
            string bus_start_at = (bus_start_hour+"."+bus_start_minute);
        }
        else {
            Console.WriteLine("Bus is out");
        }
    }
    public void next_bus_start_mod_to_kun(){
        bus_start_time_Mod_To_Khun();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Mod_To_Kun();
        int i=0;
        foreach(double bus_time in bustime){
            if (Bus_start_at_Mod_Kun<bus_time*100){
                Console.WriteLine("Next start is {0:F2}",bustime[i]);
                break;
            }
        i++;
        }
        this.bus_start_Mod_To_Khun = false;
    }
    public void next_bus_start_kun_to_mod(){
        bus_start_time_Khun_To_Mod();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Kun_To_Mod();
        int i=0;
        foreach(double bus_time in bustime){
            if (Bus_start_at_Kun_Mod<bus_time*100){
                Console.WriteLine("Next start is {0:F2}",bustime[i]);
                break;
            }
        i++;
        }
        this.bus_start_Khun_To_Mod = false;
    }
}