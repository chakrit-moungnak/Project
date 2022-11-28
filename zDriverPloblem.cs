class Driver_ploblem {
    today today = new today();
    private bool problem_check=false;
    private string problem = "";
    private DateTime time_problem;

    public bool get_problem_check(){
        return this.problem_check;
    }
    public void re_problem_check(){
        this.problem_check = false;
    }
    public void set_Driver_ploblem (){
        this.problem = Console.ReadLine();
        this.problem_check = true;
        DateTime time = DateTime.Now;
        this.time_problem = time;
    }
    public string get_Driver_ploblem(){
        return this.problem;
    }
    public DateTime get_time_driver_problem(){
        return this.time_problem;
    }
}