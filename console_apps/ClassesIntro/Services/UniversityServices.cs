using System.IO;
using System.Linq;
using System.Collections.Generic;
using ClassIntro.Models;

namespace ClassesIntro.Services;

public class UniversityServices{
    private University _university;
    public UniversityServices(University uni){
        this._university = uni;
    }

    public List<string> getFounderNames(){
        List<string> founderName = new List<string>();
        //what are looping through? => all the founders 
        //where are the founders? => this.university.Founders; (List)

        foreach(Founder individualFounder in this._university.Founders){
            // add the founders name to foundersName list
            founderName.Add(individualFounder.Name);
        }

        // same thing as foreach loop

        // for(int i = 0; i < this._university.Founders.Count; i++){
        //     founderName.Add(this._university.Founders[i].Name);
        // }


        // or 

        //founderName = this._university.Founders.Select(founder => founder.Name).ToList();

        return founderName;
    }
    public string Hello(){
        return "Hello World!";
    }
    public List<string> getDepartmentName(){
        List<string> departments = new List<string>();
        foreach(Department dep in this._university.Departments){
            departments.Add(dep.Name);
        }

        return departments;
    }

    public List<string> GetDepartmentsWithMoreThanTwoCourse(){
        List<string> deptNames = new List<string>();
        foreach(Department dept in this._university.Departments){
            if(dept.Courses.Count > 2){
                deptNames.Add(dept.Name);
            }
        }

        deptNames = this._university.Departments.Where(dept => dept.Courses.Count > 2).Select(deptartment => deptartment.Name).ToList();
        return deptNames;
    }

}
