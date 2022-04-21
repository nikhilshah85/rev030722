import { TestBed } from '@angular/core/testing';

import { AuthChildService } from './auth-child.service';

describe('AuthChildService', () => {
  let service: AuthChildService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AuthChildService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
