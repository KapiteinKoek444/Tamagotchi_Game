import { TestBed } from '@angular/core/testing';
import { ApiServiceAnimal, ApiServiceBank, ApiServiceInventory, ApiServiceService, ApiServiceShop, ApiServiceUser } from './api-service.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

describe('ApiServiceService', () => {
  let service: ApiServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule], 
      providers: [ApiServiceService,ApiServiceUser,ApiServiceAnimal,ApiServiceBank,ApiServiceInventory,ApiServiceShop]
    });
    service 
  });

  it('should be created', () => {
    const ServiceService: ApiServiceService = TestBed.inject(ApiServiceService);
    const ServiceUser: ApiServiceUser = TestBed.inject(ApiServiceUser);
    const ServiceAnimal: ApiServiceAnimal = TestBed.inject(ApiServiceAnimal);
    const ServiceBank: ApiServiceBank = TestBed.inject(ApiServiceBank);
    const ServiceInventory: ApiServiceInventory = TestBed.inject(ApiServiceInventory);
    const ServiceShop: ApiServiceShop = TestBed.inject(ApiServiceShop);
    
    expect(ServiceService).toBeTruthy();
    expect(ServiceUser).toBeTruthy();
    expect(ServiceAnimal).toBeTruthy();
    expect(ServiceBank).toBeTruthy();
    expect(ServiceInventory).toBeTruthy();
    expect(ServiceShop).toBeTruthy();
  });
});
