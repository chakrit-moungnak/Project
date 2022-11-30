class Get_Set_ticket{
    private int check;
    private int ticket_Mod_To_Khun=0;
    private int ticket_Khun_To_Mod=0;
    public void set_Mod_To_Khun(){
        this.check = 1;
    }
    public void set_Khun_To_Mod(){
        this.check = 0;
    }
    public void increase_ticket(){
        if (this.check == 1){
            this.ticket_Mod_To_Khun++;
            if (ticket_Mod_To_Khun>25){
                Console.WriteLine("you cannot get ticket");
                Console.WriteLine("Ticket is out");
                Console.WriteLine("Enter to next");
                Console.ReadLine();
                ticket_Mod_To_Khun--;
            }
        }
        else {
            this.ticket_Khun_To_Mod++;
            if (ticket_Khun_To_Mod>25){
                Console.WriteLine("you cannot get ticket");
                Console.WriteLine("Ticket is out");
                Console.WriteLine("Enter to next");
                Console.ReadLine();
                ticket_Khun_To_Mod--;
            }
        }
    }
    public void decrease_ticket(){
        if (this.check == 1){
            this.ticket_Mod_To_Khun--;
            if (ticket_Mod_To_Khun<=0){
                Console.WriteLine("You cant cancel anymore");
                Console.WriteLine("Enter to next");
                Console.ReadLine();
                this.ticket_Mod_To_Khun++;
            }
        }
        else {
            this.ticket_Khun_To_Mod++;
            if (ticket_Khun_To_Mod<=0){
                Console.WriteLine("You cant cancel anymore");
                Console.WriteLine("Enter to next");
                Console.ReadLine();
                this.ticket_Mod_To_Khun++;
            }
        }   
    }
    public void reset_ticket_Mod_To_Khun(){
        this.ticket_Mod_To_Khun=0;
    }
    public void reset_ticket_Khun_To_Mod(){
        this.ticket_Khun_To_Mod=0;
    }
    public int get_ticket_Mod_To_Khun(){
        return this.ticket_Mod_To_Khun;
    }
    public int get_ticket_Khun_To_Mod(){
        return this.ticket_Khun_To_Mod;
    }
}   
