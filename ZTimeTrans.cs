class time_trans{
    private bool bus_end = true;
    private double bus_end_time;
    private double time_tran;
    public void set_end(bool bus_end){
        if(bus_end == true){
        this.bus_end = true;
        }
        else this.bus_end=false;
    }
    private void set_bus_end_time(){
        if(this.bus_end == true){
            today today = new today();
            int bus_end_hour = today.get_this_hour();
            int bus_end_minute = today.get_this_minute();
            this.bus_end_time = bus_end_hour*100+bus_end_minute;
            string bus_end_at = (bus_end_hour+"."+bus_end_minute);
            if (bus_end_minute > bus_end_minute+10&&bus_end_minute <= bus_end_minute+20){
                Console.WriteLine("Bus is late");
                Console.WriteLine("Bus is end at = "+bus_end_at);
            }
            else Console.WriteLine("Bus is end at = "+bus_end_at);
        }
        else {
            Console.WriteLine("Bus is not end");
        }
    }
    public void set_time_trans(){
        set_bus_end_time();
        Bus_station bustimeuse = new Bus_station();
        this.time_tran = bus_end_time - bustimeuse.get_start_now();
    }
    public double get_time_trans(){
        return time_tran;
    }
}