import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnimalPickerComponent } from './animal-picker.component';

describe('AnimalPickerComponent', () => {
  let component: AnimalPickerComponent;
  let fixture: ComponentFixture<AnimalPickerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AnimalPickerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AnimalPickerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
