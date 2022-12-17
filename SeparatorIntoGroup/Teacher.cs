﻿using SeparatorIntoGroup.Options;

namespace SeparatorIntoGroup;

public class Teacher : AbstractPersons
{
    private ProjectCore _projectCore;

    public Teacher(int id, string name, string userName)
    {
        Id = id;
        PersonName = name;
        AccountName = userName;
        Status = StatusType.IsTeacher;
        _projectCore = ProjectCore.GetProjectCore();
    }

    public void CreateNewStudent(int id, string name, string userName)
    {
        Student student = new Student(id, name, userName);
        _projectCore.Students.Add(student);
        _projectCore.SaveAll();
    }
    public void DeleteStudent(Student student)
    {
        _projectCore.Students.Remove(student);
        _projectCore.SaveAll();
    }


    public void CreateNewGroup(int id, string name)
    {
        Group group = new Group(id, name);
        _projectCore.Groups.Add(group);
        _projectCore.SaveAll();
    }
    public void AddStudentToGroup(Group group, Student student)
    {
        group.AddStudentToGroup(student);
        _projectCore.SaveAll();
    }
    public void RemoveStudentFromGroup(Group group, Student student)
    {
        group.RemoveStudentFromGroup(student);
        _projectCore.SaveAll();
    }
    public void DeleteGroup(Group group)
    {
        group.ClearGroup();
        _projectCore.Groups.Remove(group);
        _projectCore.SaveAll();
    }


    public void CreateNewTeamInGroup(Group group, int id, string teamName)
    {
        group.CreateNewTeamInGroup(id,teamName);
        _projectCore.SaveAll();
    }
    public void AddStudentToTeam(Group group, Team team, Student student)
    {
        group.AddStudentToTeam(team, student);
        _projectCore.SaveAll();
    }
    public void RemoveStudentFromTeam(Group group, Team team, Student student)
    {
        group.RemoveStudentFromTeam(team,student);
        _projectCore.SaveAll();
    }
    public void DeleteTeamFromGroup(Group group, Team team)
    {
        group.DeleteTeamFromGroup(team);
        _projectCore.SaveAll();
    }
}