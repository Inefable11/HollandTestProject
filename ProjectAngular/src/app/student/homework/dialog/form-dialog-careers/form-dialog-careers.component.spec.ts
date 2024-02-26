import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormDialogCareersComponent } from './form-dialog-careers.component';

describe('FormDialogCareersComponent', () => {
  let component: FormDialogCareersComponent;
  let fixture: ComponentFixture<FormDialogCareersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormDialogCareersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormDialogCareersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
