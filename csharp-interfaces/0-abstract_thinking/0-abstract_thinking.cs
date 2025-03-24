abstract class Base(){
    public string name;
    public override string ToString(){
        return  $"{Name} is a {this.GetType().Name}";
    }
}