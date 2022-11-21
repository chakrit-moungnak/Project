using System.Collections.Generic;
using System;
class PersonList
{
    private List<Person> personlist;

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

    public bool CheckedStatus(){
        foreach(Person person in this.personlist){
            if(person is Personnel){
                return true;
            }
        }
        return false;
    }
}

    
