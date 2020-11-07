export class FoodModel {
  public id: String;
  public name: String;

  public price: number;
  public discount: number;

  public category: String;

  public foodVal: number;
  public energyVal: number;
  public happyVal: number;

  constructor(id, name, price, discount, category, foodVal, energyval, happyVal) {
    this.id = id;
    this.name = name;
    this.price = price;
    this.discount = discount;
    this.category = category;
    this.foodVal = foodVal;
    this.energyVal = energyval;
    this.happyVal = happyVal;
  }
}
