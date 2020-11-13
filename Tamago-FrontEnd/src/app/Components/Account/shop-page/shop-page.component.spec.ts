import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ShopPageComponent } from './shop-page.component';
import { RouterTestingModule } from '@angular/router/testing';

describe('ShopPageComponent', () => {
  let component: ShopPageComponent;
  let fixture: ComponentFixture<ShopPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RouterTestingModule],
      declarations: [ ShopPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShopPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
