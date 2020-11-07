export class AnimalModel {
  public id: string;
  public userId: string;
  public name: string;
  public food: number;
  public energy: number;
  public happiness: number;
  public animalType: number;

  constructor(id, Uid, n, f, e, h, type) {
    this.id = id;
    this.userId = Uid;
    this.name = n;
    this.food = f;
    this.energy = e;
    this.happiness = h;
    this.animalType = type;
  }

  public fromJSON(json) {
    for (var propName in json)
      this[propName] = json[propName];
    return this;
  }
}
