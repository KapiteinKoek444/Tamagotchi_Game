import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DinoRunComponent } from './dino-run.component';

describe('DinoRunComponent', () => {
  let component: DinoRunComponent;
  let fixture: ComponentFixture<DinoRunComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DinoRunComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DinoRunComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
