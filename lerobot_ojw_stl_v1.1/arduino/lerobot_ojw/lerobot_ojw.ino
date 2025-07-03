/*

*/
//#include <Dynamixel2Arduino.h>



#include <stdarg.h>
#include <ojw.h>



#define DXL_BUS Serial1
#define USB Serial
#define DXL_PACKET_BUFFER_LENGTH  1024




uint8_t packet_buffer[DXL_PACKET_BUFFER_LENGTH];
unsigned long led_update_time = 0;

//Dynamixel2Arduino dxl(DXL_BUS);

int m_nCmd = 0; // 1 : Command, 0: Usb 2 Dynamixel

int _BTN_TOUCH = 3;

int _ON = LOW;
int _OFF = HIGH;

CProtocol2 m_CMot;
// CTimer m_CTmr;
// CTimer m_CTmr_SW;

void setup() {
  pinMode(_BTN_TOUCH, INPUT);

  USB.begin(57600);

  // m_CTmr.Set();
  ///////////////////////////
  

  // m_CMot.SyncRead("11,12,13,14,15,16");
  // m_CMot.Load("home.txt");
  dxl.begin(USB.baud());
}

void CheckSw()
{
  if (m_nCmd == 1) 
  {
    if (digitalRead(_BTN_TOUCH) == LOW)  
    { 
      //Serial.print("LOW");
      m_CMot.Open(1000000);
      // m_CMot.SetTorq(true);
      m_CMot.SetTorq_On("11,12,13,14,15,16");
      m_CMot.Close();
      //dxl.torqueOn(254);
      m_nCmd = 0;
      // delay(100); // 채터링 방지용
      digitalWrite(LED_BUILTIN, 0);
    }    
  }
  else
  {
    if (digitalRead(_BTN_TOUCH) == HIGH)  
    {
      //Serial.print("HIGH");
      m_CMot.Open(1000000);
      // m_CMot.SetTorq(false);
      m_CMot.SetTorq_Off("11,12,13,14,15,16");
      m_CMot.Close();
      // dxl.torqueOff(254);
      m_nCmd = 1;
      // delay(100); // 채터링 방지용
      digitalWrite(LED_BUILTIN, 1);
    }
  }
}
// ==========================================================================================
// Copyright 2022 ROBOTIS CO., LTD.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

void loop() {
  CheckSw();
  // if (m_nCmd == 0)
  // {
    // put your main code here, to run repeatedly:
    dataTransceiver();

    if(USB.baud() != dxl.getPortBaud()) {
      dxl.begin(USB.baud());
    }
  // }
  // else
  // {
  // }    
}

void dataTransceiver()
{
  int length = 0;
  int i = 0;

  // USB -> DXL
  length = USB.available();
  if( length > 0 )
  {
    for(i = 0; i < length; i++)
    {
      DXL_BUS.write(USB.read());
    }
    ledStatus();
  }

  // DXL -> USB
  length = DXL_BUS.available();
  if( length > 0 )
  {
    if( length > DXL_PACKET_BUFFER_LENGTH )
    {
      length = DXL_PACKET_BUFFER_LENGTH;
    }
    for(i = 0; i < length; i++)
    {
      packet_buffer[i] = DXL_BUS.read();
    }
    USB.write(packet_buffer, length);
    ledStatus();
  }
}

void ledStatus()
{
  return;
  if((millis() - led_update_time) > 200 )
  {
    digitalWrite(LED_BUILTIN, 1);
    led_update_time = millis();
  } else {
    digitalWrite(LED_BUILTIN, 0);
  }
}