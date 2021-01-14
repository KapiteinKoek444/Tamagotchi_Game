import { EntitieBase } from './EntitieBase';

export class AnimalModel extends EntitieBase {
  public id: string;
  public userId: string;
  public name: string;
  public food: number;
  public energy: number;
  public happiness: number;
  public animalType: number;
  public experience: number;
  public level: number;

  constructor(id, Uid, n, f, e, h, type,exp, lev) {

    super();

    this.id = id;
    this.userId = Uid;
    this.name = n;
    this.food = f;
    this.energy = e;
    this.happiness = h;
    this.animalType = type;
    this.experience = exp;
    this.level = lev;
  }

}
