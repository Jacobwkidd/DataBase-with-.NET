using System;
using System.IO;
using System.Text.Json;
using ClassIntro.Models;
using ClassesIntro.Services;


// path to the json file
string jsonFile = "./university.json";

string json = File.ReadAllText(jsonFile);

//System.Console.WriteLine(json);


// JSON.parse() in javaScript
University uni = JsonSerializer.Deserialize<University>(json);

System.Console.WriteLine(uni.Departments[0].DeptHead.FullName);

UniversityServices uniService = new UniversityServices(uni);

//call the Hello method on the uniService 
//Implement the two stubbed out the method & test them.

uniService.Hello();
List<string> founderNames = uniService.getFounderNames();

foreach(string name in founderNames){
    System.Console.WriteLine(name);
}
