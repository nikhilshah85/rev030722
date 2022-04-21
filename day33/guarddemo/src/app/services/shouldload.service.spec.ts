import { TestBed } from '@angular/core/testing';

import { ShouldloadService } from './shouldload.service';

describe('ShouldloadService', () => {
  let service: ShouldloadService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShouldloadService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
