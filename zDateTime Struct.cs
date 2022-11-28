class today{
    private int This_day;
    private int This_month;
    private int This_year;
    private int This_hour;
    private int This_minute;
    private int This_second;
    private void set_date_today(){
        DateTime Today_date = DateTime.Now;
        this.This_day = Today_date.Day;
        this.This_month = Today_date.Month;
        this.This_year = Today_date.Year;
    }
    public int get_this_day(){
        set_date_today();
        return this.This_day;
    }
    public int get_this_month(){
        set_date_today();
        return This_month;
    }
    public int get_this_year(){
        set_date_today();
        return This_year;
    }
    private void set_time_now(){
        DateTime Today_date = DateTime.Now;
        this.This_hour = Today_date.Hour;
        this.This_minute = Today_date.Minute;
        this.This_second = Today_date.Second;
    }
    public int get_this_hour(){
        set_time_now();
        return This_hour;
    }
    public int get_this_minute(){
        set_time_now();
        return This_minute;
    }
    public int get_this_second(){
        set_time_now();
        return This_second;
    }
}