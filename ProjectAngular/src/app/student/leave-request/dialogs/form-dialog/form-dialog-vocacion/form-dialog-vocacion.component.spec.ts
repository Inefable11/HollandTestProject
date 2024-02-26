import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormDialogVocacionComponent } from './form-dialog-vocacion.component';

describe('FormDialogVocacionComponent', () => {
  let component: FormDialogVocacionComponent;
  let fixture: ComponentFixture<FormDialogVocacionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormDialogVocacionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormDialogVocacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
