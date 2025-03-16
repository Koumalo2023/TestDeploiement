import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MessagesComponent } from './pages/messages/messages.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MessagesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'WebApp';
}
