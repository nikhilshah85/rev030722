import { TestBed } from '@angular/core/testing';

import { ChekuserService } from './chekuser.service';

describe('ChekuserService', () => {
  let service: ChekuserService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ChekuserService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
