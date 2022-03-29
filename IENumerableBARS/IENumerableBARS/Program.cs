using IENumerableBARS;

List<Entity> entity = new List<Entity>();
string result = "";

entity.Add(new Entity() { Id = 1, ParentId = 0, Name = "Root entity" });
entity.Add(new Entity() { Id = 2, ParentId = 1, Name = "Child of 1 entity" });
entity.Add(new Entity() { Id = 3, ParentId = 1, Name = "Child of 1 entity" });
entity.Add(new Entity() { Id = 4, ParentId = 2, Name = "Child of 2 entity" });
entity.Add(new Entity() { Id = 5, ParentId = 4, Name = "Child of 4 entity" });

static Dictionary<int, List<Entity>> GetEntites(List<Entity> entities)
{
    return entities.GroupBy(x => x.ParentId).ToDictionary(x => x.Key, a => a.ToList());
}

var entities=GetEntites(entity);

foreach (var i in entities)
{
    result += $"\nKey = {i.Key},";
    result += " Value = List {";
    i.Value.ForEach(x => result += $" Entity{{Id={x.Id}}}");
    result += "}";
}
Console.WriteLine(result);