import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormDialogInstitutionsComponent } from './form-dialog-institutions.component';

describe('FormDialogInstitutionsComponent', () => {
  let component: FormDialogInstitutionsComponent;
  let fixture: ComponentFixture<FormDialogInstitutionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormDialogInstitutionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormDialogInstitutionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
