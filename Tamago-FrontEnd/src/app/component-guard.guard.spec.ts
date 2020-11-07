import { TestBed } from '@angular/core/testing';

import { ComponentGuardGuard } from './component-guard.guard';

describe('ComponentGuardGuard', () => {
  let guard: ComponentGuardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(ComponentGuardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
