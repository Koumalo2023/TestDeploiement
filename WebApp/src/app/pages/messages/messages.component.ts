import { Component, OnInit } from '@angular/core';
import { TestService } from '../../core/services/services/test.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-messages',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './messages.component.html',
  styleUrl: './messages.component.scss'
})
export class MessagesComponent implements OnInit {
  responseMessage: string = '';
  errorMessage: string = '';

  constructor(private testService: TestService) {}

  ngOnInit(): void {
    this.testBackendConnection();
  }

  testBackendConnection(): void {
    this.testService.checkBackendConnection().subscribe({
      next: (response) => {
        this.responseMessage = response.message;
      },
      error: (err) => {
        this.errorMessage = 'Erreur lors de la connexion au backend.';
        console.error(err);
      }
    });
  }
}
