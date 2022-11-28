class bus_schedule{
    private bool weekday = false;
    private bool holiday = false;

    private void day_check(){
        today today = new today();
        DateTime day_of_week = new DateTime(today.get_this_year(),today.get_this_month(),today.get_this_day());
        if (day_of_week.DayOfWeek == DayOfWeek.Saturday||day_of_week.DayOfWeek == DayOfWeek.Sunday){
            this.holiday = true;
        }
        else {
            this.weekday = true;
        }
    }
    public List<double> bus_schedule_Mod_To_Kun(){
        day_check();
        if(this.weekday == true){
            List<double> bussche= new List<double>();
            bussche.Add(07.30);
            bussche.Add(08.00);
            bussche.Add(08.15);
            bussche.Add(08.30);
            bussche.Add(09.30);
            bussche.Add(11.00);
            bussche.Add(12.00);
            bussche.Add(14.00);
            bussche.Add(16.00);
            bussche.Add(17.30);
            bussche.Add(18.00);       
            this.weekday=false;    
            return (bussche);
        }
        else if (this.holiday == true){
            List<double> bussche= new List<double>();
            bussche.Add(8.30);
            bussche.Add(12.00);
            bussche.Add(16.00);
            this.holiday=false;             
            return (bussche);
        }
        else {
            List<double> bussche= new List<double>();
            bussche.Add(8.30);
            bussche.Add(12.00);
            bussche.Add(16.00);
            this.holiday=false;            
            return (bussche);
        }
    }
    //////////////////////////////////////////////////////////////////////////////////
    public List<double> bus_schedule_Kun_To_Mod(){
        day_check();
        if(this.weekday == true){
            List<double> bussche= new List<double>();
            bussche.Add(07.00);
            bussche.Add(09.00);
            bussche.Add(10.00);
            bussche.Add(11.00);
            bussche.Add(13.00);
            bussche.Add(11.00); 
            bussche.Add(15.00);
            bussche.Add(16.30);
            bussche.Add(17.00);
            bussche.Add(18.30);
            bussche.Add(19.00);    
            bussche.Add(19.30);        
            this.weekday=false;    
            return (bussche);
        }
        else if (this.holiday == true){
            List<double> bussche= new List<double>();
            bussche.Add(10.30);
            bussche.Add(14.00);
            bussche.Add(17.00);
            this.holiday=false;             
            return (bussche);
        }
        else {
            List<double> bussche= new List<double>();
            bussche.Add(10.30);
            bussche.Add(14.00);
            bussche.Add(17.00);
            this.holiday=false;            
            return (bussche);
        }
    }
}