import { HttpClientTestingModule } from '@angular/common/http/testing';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { GuidFactory } from 'src/app/Services/GuidFactory';

import { AnimalPickerComponent } from './animal-picker.component';

describe('AnimalPickerComponent', () => {
  let component: AnimalPickerComponent;
  let fixture: ComponentFixture<AnimalPickerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientTestingModule,RouterTestingModule], 
      declarations: [ AnimalPickerComponent ],
      providers: [ GuidFactory],
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
