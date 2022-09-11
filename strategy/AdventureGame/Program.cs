// See https://aka.ms/new-console-template for more information

using Strategy.AdventureGame;
using Strategy.Weapon;

var queen= new Queen();

Console.WriteLine("---------");
queen.Fight();
queen.UseWeapon();
queen.Weapon = new SwordBehavior();
queen.UseWeapon();

Console.WriteLine("---------");
var king = new King();
king.Fight();
king.UseWeapon();
king.Weapon = new AxeBehavior();
king.UseWeapon();
