import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common'; // Import CommonModule
import { FormsModule } from '@angular/forms';  // Import FormsModule
import { CustomerService } from './customer.service'; // Ensure the service is correct
import { Customer } from './customer.model';  // Ensure Customer model is correct

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  standalone: true,  // Marking it as a standalone component
  imports: [CommonModule, FormsModule]  // Import CommonModule and FormsModule
})
export class CustomerComponent implements OnInit {
  customers: Customer[] = [];
  newCustomer: Customer = { id: '', firstName: '', lastName: '', address: '' };

  constructor(private customerService: CustomerService) {}

  ngOnInit(): void {
    this.getCustomers();
  }

  getCustomers(): void {
    this.customerService.getCustomers().subscribe((data: Customer[]) => {
      this.customers = data;  // Update customers list
    });
  }

  addCustomer(): void {
    this.customerService.createCustomer(this.newCustomer).subscribe((customer: Customer) => {
      this.customers.push(customer);  // Add new customer to list
      this.resetForm();  // Reset the form after submission
    });
  }

  // Reset the newCustomer form
  resetForm(): void {
    this.newCustomer = { id: '', firstName: '', lastName: '', address: '' };
  }
}
