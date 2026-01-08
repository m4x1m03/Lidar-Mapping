# Lidar Distance Mapping

This project is based on the game "Scanner Sombre" and its mechanic of exploring an environment relying only on Lidar data mapped in 3D. 

To achieve this, I am using an ESP32 DEVKIT V1 and a TF-Luna Lidar sensor which can be both found on Amazon. The sensor provides a range from 0 to 800 cm whith a distance accuracy of 2% from 300 to 800 cm which is plenty sufficient for this project.

Unlike the game, this is using single point scanning whereas the game scans in a cone shape. This could be implemented by making the sensor move around in a future version.



## Development Checklist

- [X]  Get the ESP32 to work
- [X]  Set up the Lidar sensor with UART
- [ ]  Set up gyroscope module to get orientation of Lidar sensor
- [ ]  Set up 3D environment on a separate computer (Ongoing using Unity)
- [ ]  Send data from ESP32 to 3D environment and map it in 360
- [ ]  Use gyroscope data to track movement and move throughout the environment (real 3D but might need to switch to something different for accurate position tracking)
- [ ]  Set up wireless data transmission from ESP32 to 3D environment

## Bonus goals
- [ ]  Use the data from the Lidar sensor and display distance on mini OLED screen
- [ ]  Set up VR to move in the environment only using Lidar data
- [ ]  Run everything directly on the ESP32 with a custom light and fast 3d renderer 


## Materials

- [DOIT ESP32 DEVKITV1](https://www.amazon.com/dp/B0BVZBTP8V?tag=happywishlist-20)
- [TF-Luna Lidar Sensor](https://www.amazon.com/dp/B09PZ559ZB?tag=happywishlist-20)
- [HiLetgo GY-521 MPU-6050 MPU6050 3 Axis Accelerometer Gyroscope Module](https://www.amazon.com/dp/B01DK83ZYQ?tag=happywishlist-20&th=1)
