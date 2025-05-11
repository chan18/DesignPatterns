/*
📌 Definition:
A form of association that represents a whole-part relationship, where the part can exist independently of the whole.

🧠 Purpose:
Represent relationships where the container does not own the life cycle of the part

🎯 Real-World Analogy:
Departments can exist without the university (e.g., a department might move to another university).

*/

public class Department
{
    public string Name { get; set; }
}

public class University
{
    public List<Department> Departments { get; set; } = new List<Department>();
}
