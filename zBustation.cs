class Bus_station{
    private bool bus_start = true;
    private double bus_start_now;
    public void set_start(bool start){
        if (start == true){
            this.bus_start = true;
        }
        else if (start == false){
            this.bus_start = false;
        }
    }
    public double get_start_now(){
        return bus_start_now;
    }
    private void bus_start_time(){
        if(this.bus_start == true){
            today today = new today();
            int bus_start_hour = today.get_this_hour();
            int bus_start_minute = today.get_this_minute();
            this.bus_start_now = bus_start_hour*100+bus_start_minute;
            string bus_start_at = (bus_start_hour+"."+bus_start_minute);
            if (bus_start_minute > bus_start_minute+10&&bus_start_minute <= bus_start_minute+20){
                Console.WriteLine("Bus is Full");
                Console.WriteLine("Bus is start at = "+bus_start_at);
            }
            else Console.WriteLine("Bus is start at = "+bus_start_at);
        }
        else {
            Console.WriteLine("Bus is not start");
        }
    }
    public void next_bus_start_mod_to_kun(){
        bus_start_time();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Mod_To_Kun();
        int i=0;
        foreach(double bus_time in bustime){
            if (bus_start_now<bus_time*100){
                Console.WriteLine("Next start is {0}",bustime[i]);
                break;
            }
        i++;
        }
        this.bus_start = false;
    }
    public void next_bus_start_kun_to_mod(){
        bus_start_time();
        bus_schedule bus = new bus_schedule();
        List<double> bustime = bus.bus_schedule_Kun_To_Mod();
        int i=0;
        foreach(double bus_time in bustime){
            if (bus_start_now<bus_time*100){
                Console.WriteLine("Next start is {0}",bustime[i]);
                break;
            }
        i++;
        }
        this.bus_start = false;
    }
}