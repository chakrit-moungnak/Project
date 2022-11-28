public abstract class Person{
    private string title;
    private string name;
    private string surname;
    private string email;
    private string username;
    private string password;
    private string admin_confirm;
public Person(string title, string name, string surname, string email, string username, string password,string admin_confirm){
    this.title = title;
    this.name = name;
    this.surname = surname;
    this.email = email;
    this.username = username;
    this.password = password;
    this.admin_confirm = admin_confirm;
}

public string GetTitle(){
    return this.title;
}

public string GetName(){
    return this.name;
}

public string GetSurname(){
    return this.surname;
}

public string GetEmail(){
    return this.email;
}

public string GetUsername(){
    return this.username;
}

public string GetPassword(){
    return this.password;
}
public string get_admin_confirm(){
    return this.admin_confirm;
}
public void set_admin_confirm(){
    Console.Write(" Please input your Y to confirm admin : ");
    this.admin_confirm = Console.ReadLine();
}
}