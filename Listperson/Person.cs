public abstract class Person{
    private string title;
    private string name;
    private string surname;
    private string email;
    private string username;
    private string password;

public Person(string title, string name, string surname, string email, string username, string password){
    this.title = title;
    this.name = name;
    this.surname = surname;
    this.email = email;
    this.username = username;
    this.password = password;
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
}