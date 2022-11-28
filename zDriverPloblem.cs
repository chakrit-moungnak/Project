class Driver_ploblem {
    private string ploblem;
    private DateTime today;
    public Driver_ploblem (string ploblem,DateTime today){
        this.ploblem = ploblem;
        this.today = today;
    }
    public string get_Driver_ploblem(){
        return ploblem;
    }
    public DateTime get_time(){
        return today;
    }
}