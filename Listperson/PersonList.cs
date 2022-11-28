using System.Collections.Generic;
using System;
class PersonList
{
    private List<Person> personlist;
    private bool admin = false;
    public PersonList(){
        this.personlist = new List<Person>();
    }
    public void AddPerson(Person person){
        this.personlist.Add(person);
    }

    public bool CheckedName(string title, string name, string surname){
        foreach(Person person in this.personlist){
            if(person.GetTitle() == title && person.GetName() == name && person.GetSurname() == surname){
                return true;
            }
        }
        return false;
    }
    
    public bool CheckedEmail(string email){
        foreach(Person person in this.personlist){
            if(person.GetEmail() == email){
                return true;
            }
        }
        return false;
    }

    public bool CheckedLogin(string username,string password){
        foreach(Person person in this.personlist){
            if(person.GetUsername() == username && person.GetPassword() == password){
                return true;
            }
        }
        return false;
    }
    public void reset_status_admin(){
        this.admin = false;
    }
    public bool get_admin(){
        return this.admin;
    }
    public void set_admin(string username,string password){
        foreach(Person person in this.personlist){
            if(username == person.GetUsername()&&password == person.GetPassword()){
                if(person.get_admin_confirm() == "y"){
                    this.admin =  true;
                }
                else this.admin = false;
            }
        }
    }

}

    
