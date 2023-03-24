-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2023 at 02:42 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `taylors_test`
--

-- --------------------------------------------------------

--
-- Table structure for table `computingquestions`
--

CREATE TABLE `computingquestions` (
  `Question` varchar(100) NOT NULL,
  `Option1` varchar(100) NOT NULL,
  `Option2` varchar(100) NOT NULL,
  `Option3` varchar(100) NOT NULL,
  `Option4` varchar(100) NOT NULL,
  `correctanswer` varchar(100) NOT NULL,
  `questionsubject` varchar(30) NOT NULL,
  `questiontopic` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `computingquestions`
--

INSERT INTO `computingquestions` (`Question`, `Option1`, `Option2`, `Option3`, `Option4`, `correctanswer`, `questionsubject`, `questiontopic`) VALUES
('What is a print statement used for in programming?', 'Displaying output', 'Accepting user input', 'Defining functions', 'Creating variables', 'Displaying output', 'computing', 'programming'),
('What is the purpose of an if statement in programming?', 'Conditional execution', 'Looping', 'Function definition', 'Variable assignment', 'Conditional execution', 'computing', 'programming'),
('What is a variable in programming?', 'A named storage location', 'A function call', 'A loop construct', 'An if statement', 'A named storage location', 'computing', 'programming'),
('What is a function in programming?', 'A reusable block of code', 'A loop construct', 'An if statement', 'A variable', 'A reusable block of code', 'computing', 'programming'),
('What is the purpose of a loop in programming?', 'Repeated execution of code', 'Conditional execution', 'Function definition', 'Variable assignment', 'Repeated execution of code', 'computing', 'programming'),
('What is a string in programming?', 'A sequence of characters', 'A mathematical expression', 'A loop construct', 'An if statement', 'A sequence of characters', 'computing', 'programming'),
('What is a boolean in programming?', 'A data type with two possible values', 'A loop construct', 'An if statement', 'A variable', 'A data type with two possible values', 'computing', 'programming'),
('What is an array in programming?', 'A collection of values', 'A loop construct', 'An if statement', 'A variable', 'A collection of values', 'computing', 'programming'),
('What is a loop variable in programming?', 'A variable used in a loop', 'A loop construct', 'An if statement', 'A mathematical expression', 'A variable used in a loop', 'computing', 'programming'),
('What is a conditional in programming?', 'A statement that controls program flow', 'A loop construct', 'An array of values', 'A variable', 'A statement that controls program flow', 'computing', 'programming'),
('What is the output of the following code? x = 5 y = 3   print(x + y)', '8', '2', '3', '5', '8', 'computing', 'programming'),
('What is the output of the following code? x = 3 y = 5   print(x * y)', '15', '8', '3', '5', '15', 'computing', 'programming'),
('What is wrong with the following code? x = 5 y = 0    z = x / y', 'Type error', 'Syntax error', 'Logic error', 'No error', 'Type error', 'computing', 'programming'),
('What is the output of the following code? x = 10 y = 3    print(x % y)', '1', '3', '10', '0', '1', 'computing', 'programming'),
('What is a variable?', 'A container for data', 'A function', 'A loop', 'A conditional', 'A container for data', 'computing', 'programming'),
('What is a for loop?', 'A loop that executes a set number of times', 'A loop that executes forever', 'A conditional statement', 'A function', 'A loop that executes a set number of times', 'computing', 'programming'),
('What is a conditional?', 'A statement that checks a condition', 'A loop', 'A function', 'A variable', 'A statement that checks a condition', 'computing', 'programming'),
('What is a function?', 'A reusable block of code', 'A loop', 'A conditional statement', 'A variable', 'A reusable block of code', 'computing', 'programming'),
('What is a parameter?', 'An input to a function', 'A loop', 'A conditional statement', 'A variable', 'An input to a function', 'computing', 'programming'),
('What is a return statement?', 'Returns a value from a function', 'Stops the execution of a loop', 'Checks a condition', 'Assigns a value to a variable', 'Returns a value from a function', 'computing', 'programming'),
('Which of the following is not an operating system?', 'Windows', 'macOS', 'iOS', 'Chrome', 'Chrome', 'computing', 'software'),
('Which of the following is not a programming language?', 'Java', 'C++', 'HTML', 'PDF', 'PDF', 'computing', 'software'),
('What is the function of a compiler?', 'Translate code', 'Run code', 'Debug code', 'Design code', 'Translate code', 'computing', 'programming'),
('Which of the following is not a type of loop?', 'While', 'Do-While', 'If-Then', 'For', 'If-Then', 'computing', 'programming'),
('Which of the following is not a data type?', 'Integer', 'Boolean', 'Float', 'Stringing', 'Stringing', 'computing', 'programming'),
('What is the name of the most commonly used web browser?', 'Google Chrome', 'Firefox', 'Safari', 'Internet Explorer', 'Google Chrome', 'computing', 'software'),
('What does HTML stand for?', 'Hypertext Markup Language', 'Hyperlink Text Markup Language', 'Hypertext Marking Language', 'Hyperlink Text Marking Language', 'Hypertext Markup Language', 'computing', 'software'),
('What is a function in programming?', 'A reusable piece of code', 'A bug in the code', 'A language construct', 'A database query', 'A reusable piece of code', 'computing', 'software'),
('What does the acronym CSS stand for?', 'Computer Style Sheets', 'Cascading Style Sheets', 'Cascading Sheets System', 'Computer Sheets Style', 'Cascading Style Sheets', 'computing', 'software'),
('Which programming language is often used for web development?', 'Java', 'C++', 'Python', 'JavaScript', 'JavaScript', 'computing', 'software'),
('What is the purpose of an operating system?', 'manage hardware', 'create documents', 'design websites', 'play games', 'manage hardware', 'computing', 'software'),
('What is the name of the code used to style web pages?', 'HTML', 'CSS', 'JavaScript', 'SQL', 'CSS', 'computing', 'software'),
('What does SQL stand for?', 'Structured Query Language', 'Sequential Query Language', 'System Query Language', 'Structured Question Language', 'Structured Query Language', 'computing', 'software'),
('What is the function of a motherboard?', 'To process data', 'To store data', 'To display data', 'To connect hardware components', 'To connect hardware components', 'computing', 'hardware'),
('Which of the following is a type of computer memory?', 'Flash memory', 'Magnetic memory', 'Optical memory', 'All of the above', 'All of the above', 'computing', 'hardware'),
('What is the maximum number of USB devices that can be connected to a single USB port?', '1', '2', '127', '256', '127', 'computing', 'hardware'),
('What does the acronym CPU stand for?', 'Central Processing Unit', 'Computer Processing Unit', 'Core Processing Unit', 'Command Processing Unit', 'Central Processing Unit', 'computing', 'hardware'),
('Which of the following is a type of optical storage device?', 'USB drive', 'CD-ROM', 'Solid-state drive', 'Hard disk drive', 'CD-ROM', 'computing', 'hardware'),
('Which of the following is not an output device?', 'Printer', 'Scanner', 'Monitor', 'Speaker', 'Scanner', 'computing', 'hardware'),
('What is the purpose of a graphics processing unit (GPU)?', 'manage computer memory', 'process user input', 'To display images', 'connect hardware components', 'To display images', 'computing', 'hardware'),
('Which of the following is an example of volatile memory?', 'ROM', 'Hard disk drive', 'Flash memory', 'RAM', 'RAM', 'computing', 'hardware'),
('Which component of a computer is responsible for performing arithmetic and logical operations?', 'CPU', 'RAM', 'GPU', 'Motherboard', 'CPU', 'computing', 'hardware'),
('What type of connector is used to connect a monitor to a computer?', 'VGA', 'USB', 'HDMI', 'Ethernet', 'VGA', 'computing', 'hardware'),
('Which component of a computer is responsible for temporarily storing data that the CPU is currently ', 'RAM', 'Hard Drive', 'SSD', 'Flash Drive', 'RAM', 'computing', 'hardware'),
('Which of the following is not an example of a solid-state drive?', 'Hard Disk Drive', 'USB Flash Drive', 'SD Card', 'NVMe Drive', 'Hard Disk Drive', 'computing', 'hardware'),
('Which component of a computer is responsible for providing power to the other components?', 'Power Supply Unit', 'Motherboard', 'CPU', 'Graphics Card', 'Power Supply Unit', 'computing', 'hardware'),
('What type of port is typically used to connect a keyboard to a computer?', 'PS/2', 'USB', 'Ethernet', 'HDMI', 'PS/2', 'computing', 'hardware'),
('Which of the following is not an example of a graphics card manufacturer?', 'Intel', 'Nvidia', 'AMD', 'ASUS', 'Intel', 'computing', 'hardware'),
('What type of storage device is typically used to store the operating system and other system files?', 'Solid State Drive', 'Hard Disk Drive', 'Optical Drive', 'Flash Drive', 'Solid State Drive', 'computing', 'hardware'),
('Which type of cable is typically used to connect a printer to a computer?', 'USB', 'Ethernet', 'HDMI', 'VGA', 'USB', 'computing', 'hardware'),
('Which of the following is not an example of an input device?', 'Printer', 'Mouse', 'Keyboard', 'Scanner', 'Printer', 'computing', 'hardware'),
('Which of these computerised systems is not categorised as Critical?', 'Air Traffic Control', 'Life Support', 'Missile Targeting', 'Graphic Design', 'Graphic Design', 'computing', 'hardware'),
('Which of these is not an Open standard', 'HTTP', 'HTML', 'XLS', 'CSS', 'XLS', 'computing', 'software'),
('The Computer Misuse Act is there to make sure that computers are used for their intended purpose onl', 'True', 'False', 'True', 'True', 'False', 'computing', 'programming'),
('Which of these is not a way of making computer systems more efficient?', 'Automatic Sleep', 'LEDs', 'Energy Efficient Processors', 'Using Virtual Servers', 'LEDs', 'computing', 'hardware'),
('In binary there are ____ numbers that can be used in each number column', '16', '10', '8', '2', '2', 'computing', 'programming'),
('A DENARY number is base _____', '20', '10', '2', '16', '10', 'computing', 'programming'),
('The biggest number you can make with 4 binary digits is _____', '15', '13', '16', '14', '15', 'computing', 'programming'),
('The biggest number you can make with a 4 digit denary number is', '999', '10000', '9999', '1000', '9999', 'computing', 'programming'),
('Denary 28 =  Binary ______', '10101', '11011', '11100', '11110', '11100', 'computing', 'programming'),
('Denary 5 = Binary ______', '111', '011', '110', '101', '101', 'computing', 'programming'),
('Hexadecimal is a base _____ number system', '10', '6', '16', '2', '16', 'computing', 'programming'),
('What are IF statements used for?', 'Making decisions', 'Repeating sections of code', 'Storing values while the program is running', 'Sharing finished programs online', 'Making decisions', 'computing', 'programming'),
('A VARIABLE is used in a computer program to ....', 'calculate the answer when two numbers are input', 'store numbers', 'named memory location that stores an input', 'Vary the amount of data', 'named memory location that stores an input', 'computing', 'programming'),
('Which 127 bit system is used by the computer to represent text?', 'ASCII', 'Floating point', 'Binary', 'RTF', 'ASCII', 'computing', 'software'),
('How does a computer process instructions?', 'By converting it into binary', 'By magic', 'splitting instruction to opcode/operand', 'By changing the format of a file', 'splitting instruction to opcode/operandr', 'computing', 'hardware'),
('What is an operator in computing?', 'Something that will change the format of a file', 'A mathematical operator', 'Something that can be done to a file', 'Something that tells the computer what the instruction is', 'A mathematical operator', 'computing', 'programming'),
('All computers have Network Interface Cards built in', 'True', 'False', 'True', 'True', 'True', 'computing', 'hardware'),
('Which of the following is external hardware?', 'Video Card', 'Keyboard', 'ROM', 'Sound Card', 'Video Card', 'computing', 'hardware'),
('Which of the following is internal hardware?', 'Sound Card', 'USB Flash Drive', 'Scanner', 'Web Cam', 'Sound Card', 'computing', 'hardware'),
('What are the two main categories of software?', 'Applications', 'Systems', 'Applications', 'Systems', 'Applications & Systems', 'computing', 'software'),
('What are the two types of drive used for permanent hardware inside a computer?', 'ROM', 'RAM', 'ROM', 'Solid State', 'Hard Disk Drive & Solid State Drive', 'computing', 'hardware'),
('Which of the following is applications software?', 'Anti-Virus', 'Device Driver', 'Database', 'Operating System', 'Database', 'computing', 'software'),
('Which of the following is systems software?', 'Video Editing', 'Spreadsheet', 'Word Processor', 'Disk Defragmentation', 'Disk Defragmentation', 'computing', 'software'),
('Which of the following is contained in the ROM BIOS?', 'Apps', 'User Interface', 'Utilities', 'Boot File', 'Boot File', 'computing', 'hardware'),
('What does BIOS stand for?', 'Basic Internet Operating System', 'Broadband Internet Operating System', 'Binary Input Output System', 'Basic Input Output System', 'Basic Input Output System', 'computing', 'hardware'),
('All computer systems have input, processes, output and...', 'Storage', 'Feedback', 'Data', 'Information', 'Storage', 'computing', 'hardware'),
('Which of the following is an input device?', 'Headphones', 'Scanner', 'Robotic Arm', 'Projector', 'Scanner', 'computing', 'hardware'),
('Which of the following is not a storage device?', 'ROM', 'RAM', 'Magnetic Tape', 'Hard Disk', 'RAM', 'computing', 'hardware'),
('Which of the following is a computers primary storage?', 'ROM', 'Magnetic Tape', 'RAM', 'Hard Disk', 'RAM', 'computing', 'hardware'),
('What is called when output from a computer system is used as input?', 'Storage', 'Processing', 'Feedback', 'Reinput', 'Feedback', 'computing', 'programming'),
('In a star network', 'devices are connected in a line', 'devices are connected to a terminal', 'devices are connected to a switch or hub', 'devices connect to each other', 'devices are connected to a switch or hub', 'computing', 'software'),
('The internet is the worlds biggest', 'LAN', 'WAN', 'WAN', 'LAN', 'WAN', 'computing', 'software'),
('What does LAN stand for?', 'Local Art Network', 'Localise Aerial Network', 'Local Area News', 'Local Area Network', 'Local Area Network', 'computing', 'software'),
('Repeaters can', 'Absorb signals', 'Amplify signals', 'Make signals slower', 'Corrupt signals', 'Amplify signals', 'computing', 'hardware'),
('What does NIC stand for?', 'New Internet Creator', 'Network Internet Card', 'Network Interceptor Card', 'Network Interface Card', 'Network Interface Card', 'computing', 'software'),
('A router can', 'Forward data packets', 'Absorb data packets', 'Repeat signals', 'Absorb signals', 'Forward data packets', 'computing', 'software'),
('Databases can have a maximum of one foreign key', 'True', 'False', 'False', 'False', 'True', 'computing', 'software'),
('What is a collection of info consisting of one or more related fields about a specific entity?', 'Table', 'Record', 'Field', 'Database', 'Record', 'computing', 'software'),
('Computer Systems consist of...', 'hardware(input/output/storage devices)', 'All of these', 'software(operating system/system software etc.)', 'Processors(the CPU chip/Graphics processors)', 'All of these', 'computing', 'hardware'),
('The __________________ tells the processor the job that needs to be done. A simple operation might b', 'Operand', 'Opcode', 'Opcode', 'Opcode', 'Opcode', 'computing', 'programming'),
('What type of software helps manage computer hardware?', 'Device Driver', 'Word Processor', 'Spreadsheet', 'Video Editor', 'Device Driver', 'computing', 'software'),
('Which of these is not a programming language?', 'Excel', 'Python', 'Java', 'C++', 'Excel', 'computing', 'software'),
('What is the name of the open-source operating system based on Linux?', 'Ubuntu', 'Windows', 'MacOS', 'Android', 'Ubuntu', 'computing', 'software'),
('What does HTML stand for?', 'Hypertext Markup Language', 'Hypertext Machine Learning', 'High Temperature Material List', 'Human Technology Management Logistics', 'Hypertext Markup Language', 'computing', 'software'),
('Which of the following is a type of computer virus?', 'Worm', 'Turtle', 'Spider', 'Lizard', 'Worm', 'computing', 'software'),
('Which of these is not a cloud storage service?', 'Adobe Acrobat', 'Google Drive', 'OneDrive', 'Dropbox', 'Adobe Acrobat', 'computing', 'software'),
('Which of these if not A real IP address?', '192.168.2.200', '192.168.2.328', '192.168.2.156', '192.168.2.1', '192.168.2.328', 'computing', 'software'),
('What does SMTP stand for?', 'Simple Mail Transition Protocol', 'Server Mail Transfer Protocol', 'Server Mailing Transfer Procedure', 'Simple Mail Transfer Protocol', 'Simple Mail Transfer Protocol', 'computing', 'software'),
('The Encryption method used on Secure Internet transitions is called?', 'Public Key Encryption', 'Public Code Encrypting', 'Private Key Encryption', 'Public Key Encrypting', 'Public Key Encryption', 'computing', 'software'),
('Encryption requires a key?', 'True', 'False', 'True', 'True', 'True', 'computing', 'software'),
('Which term describes the physical layout of a Network?', 'Topiology', 'Topology', 'Topping', 'Toppology', 'Topology', 'computing', 'hardware'),
('What is a benefit of a wired network over a wireless network?', 'Technical Knowledge needed', 'Easier to hack', 'Increased costs', 'Faster Data Transfer Speeds', 'Faster Data Transfer Speeds', 'computing', 'hardware'),
('What is a benefit of a mesh network over a star network?', 'Increased redundancy', 'There is no benefit', 'Cabling is often easier to follow', 'It costs less to set up', 'Increased redundancy', 'computing', 'hardware'),
('What is the purpose of the CPU?', 'To create PowerPoint presentations.', 'To provide power to the computer.', 'To process all the data and instructions.', 'To turn the computer on.', 'To process all the data and instructions.', 'computing', 'hardware'),
('Which legislation governs the act of hacking?', 'The Data Protection Act', 'The Freedom of Information Act', 'The Computer Misuse Act', 'The Creative Commons License', 'The Computer Misuse Act', 'computing', 'software'),
('A company produces an App using only the ASCII character set. What issue may they not have considere', 'Legal', 'Moral/Ethical', 'Cultural', 'Environmental', 'Cultural', 'computing', 'software'),
('A company produces an App using only the ASCII character set. What issue may they not have considere', 'Environmental', 'Cultural', 'Moral/Ethical', 'Legal', 'Cultural', 'computing', 'software'),
('What numeric base does Binary operate on?', '1', '2', '8', '16', '2', 'computing', 'software'),
('How Bytes are there in a Terabyte?', '1024 Megabytes', '1024 bytes', '1024 Gigabytes', '1024 Kilobytes', '1024 Gigabytes', 'computing', 'hardware'),
('Which of these is not a method for ensuring a program is robust?', 'Authentication', 'Data Sanitisation', 'Keeping passwords safe', 'Data Validation', 'Keeping passwords safe', 'computing', 'software'),
('Why is code indented?', 'To make it easier to read', 'The code does not use a { syntax and indentation is used instead', 'All of the above', 'To group together a function', 'To make it easier to read', 'computing', 'programming'),
('Which of these authentication methods is most secure?', 'Password and username', 'Password', 'Physical and Code', 'Key Card', 'Physical and Code', 'computing', 'software'),
('When a program runs it asks the user to enter their first name. Which is an example of Valid data? (', 'Sarah Jones', 'Sarah', 'Mr Jones', 'Mrs Jones', 'Sarah', 'computing', 'software'),
('Which one of these is not a method for planning for misuse? (1-4)', 'Calculating answers from formula', 'Removing duplicated letters', 'Converting lowercase to uppercase', 'Stripping unwanted characters', 'Converting lowercase to uppercase', 'computing', 'software'),
('A program has a section of code that could cause errors, which method could be used to identify this', 'Indentation', 'Authentication', 'Maintainability', 'Program Comments', 'Maintainability', 'computing', 'programming'),
('A section of a program has recently stopped working, which method could be used to resolve this issu', 'Authentication', 'Input Sanitsation', 'Data Validation', 'Maintainability', 'Maintainability', 'computing', 'programming'),
('When is terminal testing carried out? (1-3)', 'During the project', 'At the end', 'During the project', 'At the end', 'At the end', 'computing', 'software'),
('Why is code indented? (1-3)', 'To group together a function', 'To support code maintainability', 'The code may not use a { synax and indentation is used instead', 'All of the above', 'To support code maintainability', 'computing', 'programming'),
('Which of these is not a feature of a test plan? (3-5)', 'The expected outcome', 'The type of test data', 'If the testing is terminal or iterative', 'The result of the test', 'The result of the test', 'computing', 'software'),
('When is a runtime error identified? (3-5)', 'Before a program runs', 'While the program runs', 'After the program is executed', 'While the program runs', 'While the program runs', 'computing', 'programming'),
('Which line contains a syntax error? (3-5)', 'print (“hello”)', 'print(“hello)', 'print(“HELLO”)', 'sprint(“Hello”)', 'print(“hello)', 'computing', 'programming'),
('When is a runtime error identified?', 'Before a program runs', 'While the program runs', 'After the program is executed', 'After the program is executed', 'After the program is executed', 'computing', 'programming'),
('What is iterative testing?', 'Tests completed as the program is being coded', 'Testing completed after an error is found', 'Random tests on a computer program', 'Tests which are planned', 'Tests which are planned', 'computing', 'software'),
('What are the programs that run on a computer system called?', 'Algorithms', 'Code', 'software', 'Languages', 'software', 'computing', 'programming'),
('What is the answer to 1010 + 0101?', '1011', '1111', '1001', '0111', '1111', 'computing', 'software'),
('Databases are made up of one or more ......', 'Tables', 'Files', 'Tables', 'Files', 'Tables', 'computing', 'software'),
('The Barcode used for books is called', 'QR code', 'PDF 417', 'Maxi Code', 'ISBN', 'ISBN', 'computing', 'hardware'),
('What sample rate is used for CD quality sound?', '44,100Hz', '88,200Hz', '44,100Hz', '88,200Hz', '44,100Hz', 'computing', 'software'),
('What unit is sample rate measured in?', 'Bits per second', 'Megabits per second', 'Hertz', 'Hertz', 'Hertz', 'computing', 'software');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `studentid` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`studentid`, `username`, `password`) VALUES
(1, 'scoob', 'mystery'),
(2, 'rohan', 'oil'),
(3, 'yasin', 'gulam'),
(4, 'muhanad', 'maki'),
(5, 'jamie', 'burton'),
(6, 'berat', 'pirbudak'),
(7, 'aqib', 'miah'),
(8, 'testingadd', 'add'),
(10, 'testuser2', 'test'),
(11, 'yasi', 'hfd'),
(12, 'ilyas', 'hussein'),
(13, 'testingforeign', 'password'),
(14, 'burak', 'ozturk'),
(15, 'alex', 'qorosi'),
(16, 'baz', '123'),
(18, 'can', 'cayir');

--
-- Triggers `login`
--
DELIMITER $$
CREATE TRIGGER `insert_student_progress` AFTER INSERT ON `login` FOR EACH ROW BEGIN
  INSERT INTO studentprogress_computing (username, computingoverall, overallaverage, hardware_asked, hardware_correct, software_asked, software_correct, programming_asked, programming_correct)
  VALUES (NEW.username, 0, 0, 0, 0, 0, 0, 0, 0);
  
  INSERT INTO studentprogress_maths (username, mathsoverall, overallaverage, algebra_asked, algebra_correct, arithmetic_asked, arithmetic_correct, fdp_asked, fdp_correct)
  VALUES (NEW.username, 0, 0, 0, 0, 0, 0, 0, 0);
  
  INSERT INTO studentprogress_science (username, scienceoverall, overallaverage, biology_asked, biology_correct, chemistry_asked, chemistry_correct, physics_asked, physics_correct)
  VALUES (NEW.username, 0, 0, 0, 0, 0, 0, 0, 0);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `mathsquestions`
--

CREATE TABLE `mathsquestions` (
  `Question` varchar(30) NOT NULL,
  `Option1` varchar(30) NOT NULL,
  `Option2` varchar(30) NOT NULL,
  `Option3` varchar(30) NOT NULL,
  `Option4` varchar(30) NOT NULL,
  `correctanswer` varchar(30) NOT NULL,
  `questionsubject` varchar(15) NOT NULL,
  `questiontopic` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mathsquestions`
--

INSERT INTO `mathsquestions` (`Question`, `Option1`, `Option2`, `Option3`, `Option4`, `correctanswer`, `questionsubject`, `questiontopic`) VALUES
('Solve for x: 2x + 5 = 13', 'x = 3', 'x = 4', 'x = 6', 'x = 7', 'x = 6', 'maths', 'algebra'),
('Simplify the expression 3x + 2', '5x - 4y', '7x - 4y', 'x - 4y', 'x + 4y', '7x - 4y', 'maths', 'algebra'),
('Solve for x: 4(x + 3) = 32', 'x = 4', 'x = 6', 'x = 8', 'x = 10', 'x = 6', 'maths', 'algebra'),
('Simplify the expression 5x - 2', '6x + 7y', '6x - 7y', '5x + 10y', '5x + y', '6x + 7y', 'maths', 'algebra'),
('Solve for x: 3(x - 2) = 18', 'x = 6', 'x = 8', 'x = 10', 'x = 12', 'x = 8', 'maths', 'algebra'),
('Solve for x: 5x - 7 = 8', 'x = 3', 'x = 5', 'x = 9', 'x = 15', 'x = 3', 'maths', 'algebra'),
('Solve for x: 7(x - 4) = 21', 'x = 3', 'x = 4', 'x = 5', 'x = 6', 'x = 7', 'maths', 'algebra'),
('Solve for x: 2(x + 5) = 24', 'x = 6', 'x = 7', 'x = 8', 'x = 9', 'x = 7', 'maths', 'algebra'),
('Solve for x: 3x + 7 = 16', '2', '3', '4', '5', '3', 'maths', 'algebra'),
('Solve for x: 7x - 3 = 22', '3', '4', '5', '6', '5', 'maths', 'algebra'),
('Solve for x: 5x - 3 = 22', '3', '4', '5', '6', '5', 'maths', 'algebra'),
('Solve for x: 4x + 9 = 25', '4', '5', '6', '7', '4', 'maths', 'algebra'),
('Solve for x: 2(x + 3) = 10', '2', '3', '4', '5', '2', 'maths', 'algebra'),
('Solve for x: 3x + 4 = 25', '7', '8', '9', '10', '7', 'maths', 'algebra'),
('Solve for x: 5x - 2 = 23', '5', '6', '7', '8', '5', 'maths', 'algebra'),
('Solve for x: 2x - 5 = 7x + 4', '-1', '-2', '-3', '-4', '-3', 'maths', 'algebra'),
('Solve for x: 3(x + 5) = 27', '2', '3', '4', '5', '4', 'maths', 'algebra'),
('Solve for x: 5x + 3 = 28', '5', '6', '7', '8', '5', 'maths', 'algebra'),
('Solve for x: 4(x - 2) = 8', '2', '3', '4', '5', '4', 'maths', 'algebra'),
('Solve for x: 6x - 4 = 14', '2', '3', '4', '5', '3', 'maths', 'algebra'),
('Solve for x: 3(x - 4) + 2 = 5x', '1', '2', '3', '4', '4', 'maths', 'algebra'),
('Solve for x: 5x + 2 = 3(x + 4)', '-2', '-1', '0', '1', '-2', 'maths', 'algebra'),
('Solve for x: 3(2x + 1) = 21', '2', '3', '4', '5', '4', 'maths', 'algebra'),
('Solve for x: 2(x - 5) = 6x + 4', '-2', '-3', '-4', '-5', '-2', 'maths', 'algebra'),
('Solve for x: 7(x - 3) = 35', '4', '5', '6', '7', '8', 'maths', 'algebra'),
('Solve for x: 4(x - 1) + 5 = 7x', '2', '3', '4', '5', '3', 'maths', 'algebra'),
('Solve for x: 2(x - 1) - 3(2x +', '2', '3', '4', '5', '4', 'maths', 'algebra'),
('Solve for x: 4(x - 3) + 2 = 10', '3/7', '2/7', '1/7', '-1/7', '3/7', 'maths', 'algebra'),
('Solve for x: 2x - 5 = 3(x + 2)', '-11/5', '-9/5', '-7/5', '-5/7', '-11/5', 'maths', 'algebra'),
('Solve for x: 2x + 5 = 13', 'x = 3', 'x = 4', 'x = 6', 'x = 7', 'x = 6', 'maths', 'algebra'),
('Simplify the expression 3x + 2', '7x - 4y', '7x + 4y', 'x - 4y', 'x + 4y', '7x - 4y', 'maths', 'algebra'),
('Solve for x: 4(x + 3) = 32', 'x = 4', 'x = 5', 'x = 6', 'x = 7', 'x = 5', 'maths', 'algebra'),
('Solve for x: 5x - 7 = 18', 'x = 5', 'x = 4', 'x = 3', 'x = 2', 'x = 5', 'maths', 'algebra'),
('Simplify the expression 4x + 6', 'x + 4y', 'x + 2y', 'x - 4y', 'x - 2y', 'x + 4y', 'maths', 'algebra'),
('Solve for x: 3(x - 4) = -12', 'x = 0', 'x = 1', 'x = 2', 'x = 3', 'x = 0', 'maths', 'algebra'),
('Solve for x: 7x + 2 = 23', 'x = 2', 'x = 3', 'x = 4', 'x = 5', 'x = 3', 'maths', 'algebra'),
('Simplify the expression 3x + 5', '5x + 4y', '5x - 4y', 'x + 4y', 'x - 4y', '5x + 4y', 'maths', 'algebra'),
('Simplify the expression 2x + 5', '4x', '2x', '5x', '6x', '4x', 'maths', 'algebra'),
('Solve for x: 3x + 2 = 11', 'x = 3', 'x = 4', 'x = 5', 'x = 6', 'x = 3', 'maths', 'algebra'),
('Simplify the expression 5x^2 -', '3x^2 - 3x', '3x^2 + 3x', '7x^2 - 3x', '7x^2 + 3x', '3x^2 - 3x', 'maths', 'algebra'),
('Solve for x: 4x - 1 = 11', 'x = 3', 'x = 4', 'x = 5', 'x = 6', 'x = 3', 'maths', 'algebra'),
('Simplify the expression 3(x + ', 'x + 18', 'x - 18', '5x + 12', '5x - 12', '5x + 18', 'maths', 'algebra'),
('Solve for x: 7x + 4 = 45', 'x = 5', 'x = 6', 'x = 7', 'x = 8', 'x = 5', 'maths', 'algebra'),
('What is 1/4 as a decimal?', '0.75', '0.50', '0.25', '0.10', '0.25', 'maths', 'FDP'),
('What is 3/5 as a percentage?', '30%', '40%', '50%', '60%', '60%', 'maths', 'FDP'),
('What is 0.75 as a fraction in ', '3/5', '1/2', '3/4', '4/5', '3/4', 'maths', 'FDP'),
('What is 40% of 120?', '48', '50', '60', '72', '48', 'maths', 'FDP'),
('What is 25% of 80?', '15', '20', '25', '30', '20', 'maths', 'FDP'),
('What is 10% of 50?', '5', '10', '15', '20', '5', 'maths', 'FDP'),
('What is 5% of 200?', '10', '20', '25', '30', '10', 'maths', 'FDP'),
('What is 20% of 75?', '10', '15', '20', '25', '15', 'maths', 'FDP'),
('What is 12.5% of 400?', '50', '75', '100', '125', '50', 'maths', 'FDP'),
('What is 3/8 + 5/8?', '1/2', '5/8', '3/4', '7/8', '1', 'maths', 'FDP'),
('What is 1/3 + 1/6?', '1/2', '1/3', '1/6', '2/3', '1/2', 'maths', 'FDP'),
('What is 2/3 + 3/4?', '5/6', '7/8', '1', '1 1/12', '1 1/12', 'maths', 'FDP'),
('What is 4/5 - 2/5?', '1/2', '2/5', '3/5', '4/5', '2/5', 'maths', 'FDP'),
('What is 3/4 - 1/2?', '1/4', '1/2', '3/8', '5/8', '1/4', 'maths', 'FDP'),
('What is 7/8 - 2/3?', '1/8', '1/6', '5/12', '7/24', '5/24', 'maths', 'FDP'),
('What is 2/3 x 3/4?', '1/2', '1/3', '1/6', '7/12', '1/2', 'maths', 'FDP'),
('What is 3/5 x 2?', '1 1/5', '1 2/5', '1 3/5', '1 4/5', '1 1/5', 'maths', 'FDP'),
('What is 1/3 of 60?', '10', '15', '20', '30', '20', 'maths', 'FDP'),
('What is 25% of 2000?', '250', '500', '1000', '1250', '500', 'maths', 'FDP'),
('What is 60% of 50?', '30', '40', '50', '60', '30', 'maths', 'FDP'),
('What is 10% of 200?', '20', '40', '60', '80', '20', 'maths', 'FDP'),
('What is 20% of 80?', '10', '16', '20', '40', '16', 'maths', 'FDP'),
('What is 1/4 ÷ 2/3?', '3/8', '1/2', '2/3', '3/4', '3/8', 'maths', 'FDP'),
('What is 1/2 ÷ 1/4?', '1', '2', '2 1/2', '4', '2', 'maths', 'FDP'),
('What is 2/5 x 3/4?', '3/10', '3/8', '5/8', '3/5', '3/10', 'maths', 'FDP'),
('What is 5/6 x 2/3?', '5/9', '10/18', '1/2', '2/3', '5/9', 'maths', 'FDP'),
('What is 3/4 x 4/5?', '3/5', '1/2', '4/5', '12/20', '12/20', 'maths', 'FDP'),
('What is 3/8 ÷ 1/4?', '1/2', '2/3', '3/4', '4/5', '1/2', 'maths', 'FDP'),
('What is 2/3 ÷ 1/2?', '1/3', '2/3', '3/4', '4/3', '4/3', 'maths', 'FDP'),
('What is 4/5 ÷ 2/3?', '6/5', '3/4', '1 1/5', '1 3/4', '1 1/5', 'maths', 'FDP'),
('What is 3/4 of 1/2?', '3/8', '1/4', '1/3', '5/8', '3/8', 'maths', 'FDP'),
('What is 25% of 80 as a fractio', '1/5', '1/4', '1/2', '3/4', '1/4', 'maths', 'FDP'),
('What is 0.6 as a fraction in s', '3/5', '6/10', '6/100', '6/6', '3/5', 'maths', 'FDP'),
('What is 2.5 as a fraction in s', '5/4', '5/2', '25/10', '250/100', '5/2', 'maths', 'FDP'),
('What is 80% of 50 as a decimal', '0.40', '0.60', '0.80', '1.50', '0.40', 'maths', 'FDP'),
('What is 150% of 20 as a fracti', '3/2', '15/10', '15/100', '30/10', '3/2', 'maths', 'FDP'),
('What is 3.6 as a percentage?', '36%', '60%', '360%', '0.36%', '360%', 'maths', 'FDP'),
('What is 9 + 4?', '13', '14', '15', '16', '13', 'maths', 'arithmetic'),
('What is 12 - 5?', '7', '6', '5', '4', '7', 'maths', 'arithmetic'),
('What is 6 x 7?', '42', '48', '36', '30', '42', 'maths', 'arithmetic'),
('What is 84 ÷ 7?', '12', '14', '16', '18', '12', 'maths', 'arithmetic'),
('What is 15 + 29?', '44', '45', '46', '47', '44', 'maths', 'arithmetic'),
('What is 45 - 19?', '26', '27', '28', '29', '26', 'maths', 'arithmetic'),
('What is 7 x 9?', '63', '70', '72', '77', '63', 'maths', 'arithmetic'),
('What is 56 ÷ 8?', '7', '8', '9', '10', '7', 'maths', 'arithmetic'),
('What is 27 + 38?', '65', '66', '67', '68', '65', 'maths', 'arithmetic'),
('What is 72 - 35?', '37', '38', '39', '40', '37', 'maths', 'arithmetic'),
('What is 4 x 8?', '32', '34', '36', '38', '32', 'maths', 'arithmetic'),
('What is 48 ÷ 6?', '8', '9', '10', '11', '8', 'maths', 'arithmetic'),
('What is 17 + 23?', '40', '41', '42', '43', '40', 'maths', 'arithmetic'),
('What is 98 - 53?', '45', '46', '47', '48', '45', 'maths', 'arithmetic'),
('What is 3 x 6?', '18', '19', '20', '21', '18', 'maths', 'arithmetic'),
('What is 60 ÷ 5?', '12', '13', '14', '15', '12', 'maths', 'arithmetic'),
('What is 14 + 39?', '53', '54', '55', '56', '53', 'maths', 'arithmetic'),
('What is 76 - 41?', '35', '36', '37', '38', '35', 'maths', 'arithmetic'),
('What is 2 x 9?', '18', '19', '20', '21', '18', 'maths', 'arithmetic'),
('What is 48 ÷ 4?', '12', '13', '14', '15', '12', 'maths', 'arithmetic'),
('What is 32 + 15?', '47', '48', '49', '50', '47', 'maths', 'arithmetic'),
('What is 8 + 5?', '13', '14', '15', '16', '13', 'maths', 'arithmetic'),
('What is 13 - 6?', '7', '6', '5', '4', '7', 'maths', 'arithmetic'),
('What is 7 x 8?', '56', '48', '36', '30', '56', 'maths', 'arithmetic'),
('What is 56 ÷ 8?', '7', '8', '9', '10', '7', 'maths', 'arithmetic'),
('What is 14 + 33?', '47', '45', '46', '44', '47', 'maths', 'arithmetic'),
('What is 35 - 19?', '16', '17', '18', '19', '16', 'maths', 'arithmetic'),
('What is 8 x 7?', '56', '63', '72', '77', '56', 'maths', 'arithmetic'),
('What is 48 ÷ 6?', '8', '9', '10', '11', '8', 'maths', 'arithmetic'),
('What is 23 + 34?', '57', '56', '58', '59', '57', 'maths', 'arithmetic'),
('What is 57 - 25?', '32', '33', '34', '35', '32', 'maths', 'arithmetic'),
('What is 3 x 7?', '21', '24', '27', '30', '21', 'maths', 'arithmetic'),
('What is 63 ÷ 9?', '7', '8', '9', '10', '7', 'maths', 'arithmetic'),
('What is 15 + 19?', '34', '33', '32', '31', '34', 'maths', 'arithmetic'),
('What is 86 - 48?', '38', '37', '36', '35', '38', 'maths', 'arithmetic'),
('What is 4 x 7?', '28', '24', '21', '20', '28', 'maths', 'arithmetic'),
('What is 72 ÷ 6?', '12', '13', '14', '15', '12', 'maths', 'arithmetic'),
('What is 21 + 31?', '52', '51', '53', '54', '52', 'maths', 'arithmetic'),
('What is 89 - 46?', '43', '44', '45', '46', '43', 'maths', 'arithmetic'),
('What is 2 x 8?', '16', '14', '12', '10', '16', 'maths', 'arithmetic'),
('What is 48 ÷ 4?', '12', '13', '14', '15', '12', 'maths', 'arithmetic'),
('What is 42 + 15?', '57', '56', '58', '59', '57', 'maths', 'arithmetic'),
('What is 56 - 23?', '33', '32', '31', '30', '33', 'maths', 'arithmetic'),
('What is 4 + 9?', '13', '14', '15', '16', '13', 'maths', 'arithmetic'),
('What is 19 - 9?', '10', '9', '8', '7', '10', 'maths', 'arithmetic'),
('What is 5 x 9?', '45', '40', '35', '30', '45', 'maths', 'arithmetic'),
('What is 36 ÷ 9?', '4', '5', '6', '7', '4', 'maths', 'arithmetic'),
('What is 13 + 15?', '28', '27', '26', '25', '28', 'maths', 'arithmetic'),
('What is 45 - 29?', '16', '17', '18', '19', '16', 'maths', 'arithmetic'),
('What is 8 x 9?', '72', '64', '56', '48', '72', 'maths', 'arithmetic'),
('What is 72 ÷ 9?', '8', '9', '10', '11', '8', 'maths', 'arithmetic'),
('What is 29 + 37?', '66', '67', '68', '69', '66', 'maths', 'arithmetic'),
('What is 67 - 45?', '22', '23', '24', '25', '22', 'maths', 'arithmetic'),
('What is 4 x 9?', '36', '32', '28', '24', '36', 'maths', 'arithmetic'),
('What is 54 ÷ 9?', '6', '7', '8', '9', '6', 'maths', 'arithmetic'),
('What is 17 + 29?', '46', '45', '44', '43', '46', 'maths', 'arithmetic'),
('What is 81 - 47?', '34', '33', '32', '31', '34', 'maths', 'arithmetic'),
('What is 6 x 9?', '54', '48', '42', '36', '54', 'maths', 'arithmetic'),
('What is 63 ÷ 9?', '7', '8', '9', '10', '7', 'maths', 'arithmetic'),
('What is 27 + 34?', '61', '60', '59', '58', '61', 'maths', 'arithmetic'),
('What is 89 - 54?', '35', '34', '33', '32', '35', 'maths', 'arithmetic'),
('What is 3 x 9?', '27', '24', '21', '18', '27', 'maths', 'arithmetic'),
('What is 45 ÷ 5?', '9', '8', '7', '6', '9', 'maths', 'arithmetic'),
('What is 24 + 18?', '42', '41', '40', '39', '42', 'maths', 'arithmetic'),
('What is 56 - 36?', '20', '19', '18', '17', '20', 'maths', 'arithmetic');

-- --------------------------------------------------------

--
-- Table structure for table `sciencequestions`
--

CREATE TABLE `sciencequestions` (
  `Question` varchar(100) NOT NULL,
  `Option1` varchar(100) NOT NULL,
  `Option2` varchar(100) NOT NULL,
  `Option3` varchar(100) NOT NULL,
  `Option4` varchar(100) NOT NULL,
  `correctanswer` varchar(100) NOT NULL,
  `questionsubject` varchar(30) NOT NULL,
  `questiontopic` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sciencequestions`
--

INSERT INTO `sciencequestions` (`Question`, `Option1`, `Option2`, `Option3`, `Option4`, `correctanswer`, `questionsubject`, `questiontopic`) VALUES
('What is the process by which green plants make their own food called?', 'Photosynthesis', 'Respiration', 'Transpiration', 'Pollination', 'Photosynthesis', 'science', 'biology'),
('What is the basic unit of life called?', 'Atom', 'Molecule', 'Cell', 'Organism', 'Cell', 'science', 'biology'),
('Which of the following is not a type of blood cell?', 'Platelets', 'Red blood cells', 'White blood cells', 'Brain cells', 'Brain cells', 'science', 'biology'),
('What is the function of the heart?', 'To pump blood', 'To digest food', 'To filter blood', 'To store blood', 'To pump blood', 'science', 'biology'),
('What is the role of the lungs?', 'To breathe in oxygen and exhale carbon dioxide', 'To filter blood', 'To pump blood', 'To store air', 'To breathe in oxygen and exhale carbon dioxide', 'science', 'biology'),
('Which of the following is not part of the digestive system?', 'Liver', 'Stomach', 'Lungs', 'Intestines', 'Lungs', 'science', 'biology'),
('What is the job of the kidneys?', 'To filter waste products from the blood', 'To produce red blood cells', 'To digest food', 'To pump blood', 'To filter waste products from the blood', 'science', 'biology'),
('What is the purpose of the skeletal system?', 'To provide support and protection for the body', 'To circulate blood throughout the body', 'To produce hormones', 'To control movement', 'To provide support and protection for the body', 'science', 'biology'),
('What is the purpose of the muscular system?', 'To allow movement', 'To produce hormones', 'To filter blood', 'To digest food', 'To allow movement', 'science', 'biology'),
('What is the function of the nervous system?', 'To control and coordinate the bodys functions', 'To filter blood', 'To digest food', 'To produce hormones', 'To control and coordinate the bodys functions', 'science', 'biology'),
('Which of the following is not a type of tissue in the human body?', 'Heart tissue', 'Muscle tissue', 'Nerve tissue', 'Leaf tissue', 'Leaf tissue', 'science', 'biology'),
('What is the role of the endocrine system?', 'To produce hormones', 'To digest food', 'To filter blood', 'To control movement', 'To produce hormones', 'science', 'biology'),
('What is the function of the circulatory system?', 'To transport oxygen, nutrients, and waste products throughout the body', 'To produce hormones', 'To digest food', 'To filter blood', 'To transport oxygen, nutrients, and waste products throughout the body', 'science', 'biology'),
('Which of the following is NOT a component of the circulatory system?', 'Heart', 'Blood vessels', 'Lungs', 'Kidneys', 'Kidneys', 'science', 'biology'),
('Which of the following is the correct order of the levels of biological organization from smallest t', 'Organism, cell, tissue, organ system, population', 'Cell, tissue, organism, organ system, population', 'Tissue, organ system, organism, cell, population', 'Cell, tissue, organ system, organism, population', 'Cell, tissue, organ system, organism, population', 'science', 'biology'),
('Which of the following best describes the process of photosynthesis?', 'Conversion of light energy into chemical energy', 'Conversion of chemical energy into light energy', 'Conversion of thermal energy into chemical energy', 'Conversion of chemical energy into thermal energy', 'Conversion of light energy into chemical energy', 'science', 'biology'),
('Which of the following is an example of an abiotic factor in an ecosystem?', 'Trees', 'Water', 'Deer', 'Insects', 'Water', 'science', 'biology'),
('Which of the following is NOT part of the digestive system?', 'Lungs', 'Stomach', 'Small intestine', 'Large intestine', 'Lungs', 'science', 'biology'),
('Which of the following is the correct order of the scientific method?', 'Hypothesis, observation, experiment, conclusion', 'Observation, experiment, hypothesis, conclusion', 'Experiment, hypothesis, observation, conclusion', 'Observation, hypothesis, experiment, conclusion', 'Observation, hypothesis, experiment, conclusion', 'science', 'biology'),
('Which of the following is an example of a herbivore?', 'Lion', 'Tiger', 'Deer', 'Wolf', 'Deer', 'science', 'biology'),
('Which of the following is NOT a type of tissue in the human body?', 'Muscle', 'Nerve', 'Bone', 'Vein', 'Vein', 'science', 'biology'),
('Which of the following is the correct order of the phases of mitosis?', 'Prophase, metaphase, anaphase, telophase', 'Anaphase, telophase, prophase, metaphase', 'Metaphase, prophase, anaphase, telophase', 'Prophase, metaphase, telophase, anaphase', 'Prophase, metaphase, anaphase, telophase', 'science', 'biology'),
('Which of the following is an example of a parasite?', 'Bacteria', 'Fungus', 'Virus', 'Tick', 'Tick', 'science', 'biology'),
('Which of the following is the function of the respiratory system?', 'To filter waste products from the blood', 'To transport nutrients throughout the body', 'To regulate body temperature', 'To exchange gases with the environment', 'To exchange gases with the environment', 'science', 'biology'),
('Which of the following is NOT part of the nervous system?', 'Stomach', 'Brain', 'Spinal cord', 'Nerves', 'Stomach', 'science', 'biology'),
('Which of the following is not a cell organelle?', 'nucleus', 'ribosome', 'enzyme', 'mitochondria', 'enzyme', 'science', 'biology'),
('Which of the following animals is a herbivore?', 'lion', 'penguin', 'hippopotamus', 'gazelle', 'gazelle', 'science', 'biology'),
('Which of the following is not a mammal?', 'whale', 'shark', 'lion', 'monkey', 'shark', 'science', 'biology'),
('Which of the following is not a type of blood vessel?', 'artery', 'vein', 'capillary', 'ligament', 'ligament', 'science', 'biology'),
('Which of the following is not a type of muscle?', 'skeletal', 'cardiac', 'voluntary', 'smooth', 'voluntary', 'science', 'biology'),
('Which of the following is not part of the digestive system?', 'liver', 'stomach', 'intestines', 'kidneys', 'kidneys', 'science', 'biology'),
('What is the function of the respiratory system?', 'to transport oxygen around the body', 'to remove waste products from the body', 'to regulate body temperature', 'to protect the body from infection', 'to transport oxygen around the body', 'science', 'biology'),
('Which of the following is not a type of plant tissue?', 'epithelial', 'dermal', 'vascular', 'ground', 'epithelial', 'science', 'biology'),
('Which of the following is not a type of bone?', 'femur', 'sternum', 'cranium', 'metacarpal', 'metacarpal', 'science', 'biology'),
('Which of the following is not a type of joint?', 'hinge', 'ball and socket', 'gliding', 'fixed', 'fixed', 'science', 'biology'),
('What is the process by which plants release water vapor through their leaves called?', 'photosynthesis', 'transpiration', 'respiration', 'evaporation', 'transpiration', 'science', 'biology'),
('Which of the following is not a type of rock?', 'igneous', 'metamorphic', 'sedimentary', 'crystalline', 'crystalline', 'science', 'biology'),
('What is the smallest unit of matter?', 'molecule', 'atom', 'cell', 'organism', 'atom', 'science', 'biology'),
('Which of the following is not a type of energy?', 'potential', 'kinetic', 'nuclear', 'chemical', 'nuclear', 'science', 'biology'),
('What is the process by which a solid turns into a gas without passing through a liquid state called?', 'evaporation', 'sublimation', 'condensation', 'melting', 'sublimation', 'science', 'biology'),
('What is the difference between an acid and a base?', 'An acid has a pH below 7, while a base has a pH above 7', 'An acid has a pH above 7, while a base has a pH below 7', 'An acid is a solid, while a base is a liquid', 'An acid is a liquid, while a base is a gas', 'An acid has a pH below 7, while a base has a pH above 7', 'science', 'chemistry'),
('What is a pH scale?', 'A scale that measures how acidic or basic a substance is', 'A scale that measures how hot or cold a substance is', 'A scale that measures how dense a substance is', 'A scale that measures how heavy a substance is', 'A scale that measures how acidic or basic a substance is', 'science', 'chemistry'),
('What is the pH level of water?', '7', '1', '14', '10', '7', 'science', 'chemistry'),
('What is the pH level of vinegar?', '2-3', '7', '11-12', '4-5', '2-3', 'science', 'chemistry'),
('What is the pH level of lemon juice?', '2', '7', '11', '5', '2', 'science', 'chemistry'),
('What is the pH level of baking soda?', '9', '3', '7', '11', '9', 'science', 'chemistry'),
('What is an acid-base indicator?', 'A substance that changes color in the presence of an acid or a base', 'A substance that neutralizes acids and bases', 'A substance that dissolves in water', 'A substance that changes shape when exposed to heat', 'A substance that changes color in the presence of an acid or a base', 'science', 'chemistry'),
('What is the most common gas in the Earths atmosphere?', 'Nitrogen', 'Oxygen', 'Carbon dioxide', 'Argon', 'Nitrogen', 'science', 'chemistry'),
('What gas do plants absorb during photosynthesis?', 'Carbon dioxide', 'Oxygen', 'Nitrogen', 'Hydrogen', 'Carbon dioxide', 'science', 'chemistry'),
('What is photosynthesis?', 'The process by which plants make food using sunlight, carbon dioxide, and water', 'The process by which plants absorb water from the soil', 'The process by which plants produce oxygen', 'The process by which plants release carbon dioxide', 'The process by which plants make food using sunlight, carbon dioxide, and water', 'science', 'chemistry'),
('What is the chemical formula for glucose?', 'C6H12O6', 'H2O', 'CO2', 'NaCl', 'C6H12O6', 'science', 'chemistry'),
('What is the chemical formula for water?', 'H2O', 'CO2', 'NaCl', 'C6H12O6', 'H2O', 'science', 'chemistry'),
('What is the chemical formula for carbon dioxide?', 'CO2', 'H2O', 'NaCl', 'C6H12O6', 'CO2', 'science', 'chemistry'),
('What is the smallest particle of matter?', 'Atom', 'Molecule', 'Element', 'Compound', 'Atom', 'science', 'chemistry'),
('What are the three states of matter?', 'Solid, liquid, gas', 'Water, ice, steam', 'Salt, sugar, pepper', 'Hot, cold, lukewarm', 'Solid, liquid, gas', 'science', 'chemistry'),
('What happens when you heat water?', 'It boils and turns into steam', 'It freezes and turns into ice', 'It evaporates and turns into gas', 'It changes color', 'It boils and turns into steam', 'science', 'chemistry'),
('What is the chemical symbol for oxygen?', 'O', 'C', 'H', 'N', 'O', 'science', 'chemistry'),
('What is the chemical symbol for carbon?', 'C', 'O', 'H', 'N', 'C', 'science', 'chemistry'),
('What is the chemical symbol for hydrogen?', 'H', 'O', 'C', 'N', 'H', 'science', 'chemistry'),
('What is the chemical symbol for nitrogen?', 'N', 'C', 'H', 'O', 'N', 'science', 'chemistry'),
('What is a chemical reaction?', 'A process that changes one or more substances into new substances', 'A process that changes the state of matter', 'A process that changes the temperature of a substance', 'A process that changes the shape of a substance', 'A process that changes one or more substances into new substances', 'science', 'chemistry'),
('What is an element?', 'A substance made up of only one type of atom', 'A substance made up of two or more types of atoms', 'A substance made up of only one type of molecule', 'A substance made up of two or more types of molecules', 'A substance made up of only one type of atom', 'science', 'chemistry'),
('What is a compound?', 'A substance made up of two or more types of atoms', 'A substance made up of only one type of atom', 'A substance made up of two or more types of molecules', 'A substance made up of only one type of molecule', 'A substance made up of two or more types of atoms', 'science', 'chemistry'),
('What is a mixture?', 'A combination of two or more substances that are not chemically bonded', 'A combination of two or more substances that are chemically bonded', 'A substance made up of only one type of molecule', 'A substance made up of only one type of atom', 'A combination of two or more substances that are not chemically bonded', 'science', 'chemistry'),
('What are hydrocarbons?', 'Organic compounds made of hydrogen and carbon atoms', 'Inorganic compounds made of hydrogen and oxygen atoms', 'Inorganic compounds made of carbon and oxygen atoms', 'Organic compounds made of carbon and oxygen atoms', 'Organic compounds made of hydrogen and carbon atoms', 'science', 'chemistry'),
('What is the main function of carbohydrates in our body?', 'To provide energy', 'To build muscle', 'To transport oxygen', 'To fight infection', 'To provide energy', 'science', 'chemistry'),
('What is the main function of proteins in our body?', 'To build and repair tissues', 'To store energy', 'To transport oxygen', 'To fight infection', 'To build and repair tissues', 'science', 'chemistry'),
('What is the main function of lipids in our body?', 'To store energy and provide insulation', 'To build muscle', 'To transport oxygen', 'To fight infection', 'To store energy and provide insulation', 'science', 'chemistry'),
('What is the difference between a physical change and a chemical change?', 'A physical change does not change the identity of the substance, while a chemical change does', 'A physical change changes the identity of the substance, while a chemical change does not', 'A physical change involves a change in temperature, while a chemical change does not', 'A physical change involves a change in color, while a chemical change does not', 'A physical change does not change the identity of the substance, while a chemical change does', 'science', 'chemistry'),
('What is a chemical reaction?', 'A process that changes one set of chemicals into another set of chemicals', 'A process that changes the temperature of a substance', 'A process that changes the color of a substance', 'A process that changes the shape of a substance', 'A process that changes one set of chemicals into another set of chemicals', 'science', 'chemistry'),
('What is combustion?', 'A chemical reaction that involves the burning of a fuel', 'A chemical reaction that involves the mixing of two substances', 'A physical change that involves a change in temperature', 'A physical change that involves a change in color', 'A chemical reaction that involves the burning of a fuel', 'science', 'chemistry'),
('What is oxidation?', 'A chemical reaction that involves the loss of electrons', 'A chemical reaction that involves the gain of electrons', 'A physical change that involves a change in temperature', 'A physical change that involves a change in color', 'A chemical reaction that involves the loss of electrons', 'science', 'chemistry'),
('What is reduction?', 'A chemical reaction that involves the gain of electrons', 'A chemical reaction that involves the loss of electrons', 'A physical change that involves a change in temperature', 'A physical change that involves a change in color', 'A chemical reaction that involves the gain of electrons', 'science', 'chemistry'),
('What is the force of gravity?', 'A force that pushes things apart', 'A force that pulls things together', 'A force that makes things spin', 'A force that changes direction', 'A force that pulls things together', 'science', 'physics'),
('How do magnets work?', 'They produce electricity', 'They attract or repel other magnets', 'They make things hot', 'They create sound waves', 'They attract or repel other magnets', 'science', 'physics'),
('How do we measure weight?', 'With a ruler', 'With a scale', 'With a thermometer', 'With a compass', 'With a scale', 'science', 'physics'),
('What is kinetic energy?', 'Energy from motion', 'Energy from sound', 'Energy from light', 'Energy from heat', 'Energy from motion', 'science', 'physics'),
('What is potential energy?', 'Stored energy', 'Energy from motion', 'Energy from sound', 'Energy from light', 'Stored energy', 'science', 'physics'),
('What is a simple machine?', 'A machine that uses electricity', 'A machine with few or no moving parts', 'A machine that can think', 'A machine that is very complex', 'A machine with few or no moving parts', 'science', 'physics'),
('How does a lever work?', 'By moving in a straight line', 'By rotating around a fixed point', 'By vibrating back and forth', 'By spinning in circles', 'By rotating around a fixed point', 'science', 'physics'),
('What is friction?', 'A force that pulls things apart', 'A force that pushes things together', 'A force that makes things spin', 'A force that changes direction', 'A force that pushes things together', 'science', 'physics'),
('How does air resistance affect falling objects?', 'It slows them down', 'It speeds them up', 'It makes them change direction', 'It makes them disappear', 'It slows them down', 'science', 'physics'),
('What is the difference between speed and velocity?', 'Speed is how fast something is moving; velocity is how far it has gone', 'Speed is how far something has gone; velocity is how fast it is moving', 'There is no difference', 'Velocity is a type of speed', 'Speed is how fast something is moving; velocity is how far it has gone', 'science', 'physics'),
('What is a conductor?', 'A material that electricity cannot flow through', 'A material that allows electricity to flow through it easily', 'A machine that generates electricity', 'A machine that stores electricity', 'A material that allows electricity to flow through it easily', 'science', 'physics'),
('What is an insulator?', 'A material that electricity cannot flow through', 'A material that allows electricity to flow through it easily', 'A machine that generates electricity', 'A machine that stores electricity', 'A material that electricity cannot flow through', 'science', 'physics'),
('What is reflection?', 'The bending of light waves', 'The splitting of light into different colors', 'The bouncing of light off a surface', 'The blocking of light by an object', 'The bouncing of light off a surface', 'science', 'physics'),
('What is refraction?', 'The bending of light waves', 'The splitting of light into different colors', 'The bouncing of light off a surface', 'The blocking of light by an object', 'The bending of light waves', 'science', 'physics'),
('What is a prism?', 'A type of lens', 'A type of mirror', 'A device that splits white light into its colors', 'A device that reflects light in a single direction', 'A device that splits white light into its colors', 'science', 'physics'),
('What is the law of conservation of energy?', 'Energy cannot be created or destroyed, only transformed from one form to another', 'Energy can be created or destroyed', 'Energy can only be transformed into heat', 'Energy cannot be transformed into motion', 'Energy cannot be created or destroyed, only transformed from one form to another', 'science', 'physics'),
('What is the law of conservation of mass?', 'Mass cannot be created or destroyed, only transformed from one form to another', 'Mass can be created or destroyed', 'Mass can only be transformed into energy', 'Mass cannot be transformed into motion', 'Mass cannot be created or destroyed, only transformed from one form to another', 'science', 'physics'),
('What is sound?', 'A type of light wave', 'A type of electric wave', 'A type of magnetic wave', 'A type of mechanical wave', 'A type of mechanical wave', 'science', 'physics'),
('What is the speed of sound?', '343 meters per second', '186,000 miles per second', '1 meter per second', '10 meters per second', '343 meters per second', 'science', 'physics'),
('What is frequency?', 'The number of waves that pass by a point in a given amount of time', 'The distance between two points on a wave', 'The height of a wave', 'The shape of a wave', 'The number of waves that pass by a point in a given amount of time', 'science', 'physics'),
('What is wavelength?', 'The distance between two points on a wave', 'The number of waves that pass by a point in a given amount of time', 'The height of a wave', 'The shape of a wave', 'The distance between two points on a wave', 'science', 'physics'),
('What is amplitude?', 'The height of a wave', 'The distance between two points on a wave', 'The number of waves that pass by a point in a given amount of time', 'The shape of a wave', 'The height of a wave', 'science', 'physics'),
('What is a wave?', 'A disturbance that travels through a medium', 'A type of particle', 'A form of energy', 'A form of matter', 'A disturbance that travels through a medium', 'science', 'physics'),
('What is a medium?', 'A type of particle', 'A form of energy', 'A form of matter', 'A substance through which a wave can travel', 'A substance through which a wave can travel', 'science', 'physics'),
('What is the electromagnetic spectrum?', 'The range of all types of electromagnetic radiation', 'The range of all types of sound', 'The range of all types of matter', 'The range of all types of energy', 'The range of all types of electromagnetic radiation', 'science', 'physics'),
('What is an electromagnet?', 'A type of permanent magnet', 'A magnet made by electricity', 'A magnet made of iron', 'A magnet made of steel', 'A magnet made by electricity', 'science', 'physics'),
('What is a circuit?', 'A loop that electricity can flow through', 'A type of magnet', 'A type of battery', 'A type of wire', 'A loop that electricity can flow through', 'science', 'physics'),
('What is an electric current?', 'The flow of electricity through a circuit', 'The resistance to electricity in a circuit', 'The amount of electricity in a circuit', 'The voltage of electricity in a circuit', 'The flow of electricity through a circuit', 'science', 'physics'),
('What is voltage?', 'The force that pushes electricity through a circuit', 'The flow of electricity through a circuit', 'The resistance to electricity in a circuit', 'The amount of electricity in a circuit', 'The force that pushes electricity through a circuit', 'science', 'physics'),
('What is resistance?', 'The opposition to the flow of electricity in a circuit', 'The force that pushes electricity through a circuit', 'The amount of electricity in a circuit', 'The voltage of electricity in a circuit', 'The opposition to the flow of electricity in a circuit', 'science', 'physics'),
('What is a battery?', 'A device that stores electrical energy', 'A device that creates electrical energy', 'A device that converts electrical energy into mechanical energy', 'A device that converts mechanical energy into electrical energy', 'A device that stores electrical energy', 'science', 'physics'),
('What is an insulator?', 'A material that does not allow electricity to flow through it easily', 'A material that allows electricity to flow through it easily', 'A material that stores electricity', 'A material that creates electricity', 'A material that does not allow electricity to flow through it easily', 'science', 'physics'),
('What is a conductor?', 'A material that allows electricity to flow through it easily', 'A material that does not allow electricity to flow through it easily', 'A material that stores electricity', 'A material that creates electricity', 'A material that allows electricity to flow through it easily', 'science', 'physics'),
('What is Ohms law?', 'The relationship between voltage, current, and resistance in a circuit', 'The relationship between electricity and magnetism', 'The relationship between light and sound', 'The relationship between energy and matter', 'The relationship between voltage, current, and resistance in a circuit', 'science', 'physics'),
('What is a magnetic field?', 'The area around a magnet where its force can be detected', 'The area around a battery where its force can be detected', 'The area around an electric circuit where its force can be detected', 'The area around a wire where its force can be detected', 'The area around a magnet where its force can be detected', 'science', 'physics'),
('What is a magnetic pole?', 'The ends of a magnet where its force is strongest', 'The center of a magnet where its force is strongest', 'The sides of a magnet where its force is strongest', 'The area around a magnet where its force is strongest', 'The ends of a magnet where its force is strongest', 'science', 'physics'),
('What is a magnetic force?', 'The force that attracts or repels magnets', 'The force that moves magnets', 'The force that creates magnets', 'The force that stores magnets', 'The force that attracts or repels magnets', 'science', 'physics'),
('What is a magnetic domain?', 'A region in a magnet where the atoms are all aligned', 'A region in a magnet where the atoms are randomly aligned', 'A region in a magnet where the atoms are moving', 'A region in a magnet where the atoms are not aligned', 'A region in a magnet where the atoms are all aligned', 'science', 'physics'),
('What is a compass?', 'A device that uses Earths magnetic field to show direction', 'A device that measures voltage', 'A device that measures current', 'A device that measures resistance', 'A device that uses Earths magnetic field to show direction', 'science', 'physics'),
('What is static electricity?', 'A build-up of electric charge on the surface of an object', 'A build-up of magnetic charge on the surface of an object', 'A build-up of light energy on the surface of an object', 'A build-up of sound energy on the surface of an object', 'A build-up of electric charge on the surface of an object', 'science', 'physics'),
('What is a lightning rod?', 'A device that protects buildings from lightning strikes', 'A device that creates lightning', 'A device that attracts lightning', 'A device that measures lightning', 'A device that protects buildings from lightning strikes', 'science', 'physics'),
('What is an atom?', 'The basic building block of matter', 'The basic building block of energy', 'The basic building block of electricity', 'The basic building block of magnetism', 'The basic building block of matter', 'science', 'physics'),
('What is a molecule?', 'A group of atoms bonded together', 'A group of electrons bonded together', 'A group of protons bonded together', 'A group of neutrons bonded together', 'A group of atoms bonded together', 'science', 'physics'),
('What is a solid?', 'A state of matter that has a fixed shape and volume', 'A state of matter that has a fixed shape but not a fixed volume', 'A state of matter that has a fixed volume but not a fixed shape', 'A state of matter that does not have a fixed shape or volume', 'A state of matter that has a fixed shape and volume', 'science', 'physics'),
('What is a liquid?', 'A state of matter that has a fixed volume but not a fixed shape', 'A state of matter that has a fixed shape and volume', 'A state of matter that does not have a fixed shape or volume', 'A state of matter that has a fixed shape but not a fixed volume', 'A state of matter that has a fixed volume but not a fixed shape', 'science', 'physics');

-- --------------------------------------------------------

--
-- Table structure for table `studentprogress_computing`
--

CREATE TABLE `studentprogress_computing` (
  `username` varchar(50) NOT NULL,
  `computingoverall` float DEFAULT 0,
  `overallaverage` float DEFAULT 0,
  `hardware_asked` float DEFAULT 0,
  `hardware_correct` float DEFAULT 0,
  `software_asked` float DEFAULT 0,
  `software_correct` float DEFAULT 0,
  `programming_asked` float DEFAULT 0,
  `programming_correct` float DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studentprogress_computing`
--

INSERT INTO `studentprogress_computing` (`username`, `computingoverall`, `overallaverage`, `hardware_asked`, `hardware_correct`, `software_asked`, `software_correct`, `programming_asked`, `programming_correct`) VALUES
('alex', 0, 0, 0, 0, 0, 0, 0, 0),
('aqib', 0, 0, 0, 0, 0, 0, 0, 0),
('baz', 0, 0, 0, 0, 0, 0, 0, 0),
('berat', 0, 0, 0, 0, 0, 0, 0, 0),
('burak', 0, 0, 0, 0, 0, 0, 0, 0),
('can', 0, 0, 0, 0, 0, 0, 0, 0),
('ilyas', 0, 0, 0, 0, 0, 0, 0, 0),
('jamie', 0, 0, 0, 0, 0, 0, 0, 0),
('muhanad', 0, 0, 0, 0, 0, 0, 0, 0),
('rohan', 0, 0, 0, 0, 0, 0, 0, 0),
('scoob', 0, 0, 0, 0, 0, 0, 0, 0),
('yasin', 50, 30, 41, 20, 39, 18, 40, 20);

-- --------------------------------------------------------

--
-- Table structure for table `studentprogress_maths`
--

CREATE TABLE `studentprogress_maths` (
  `username` varchar(50) NOT NULL,
  `mathsoverall` float DEFAULT 0,
  `overallaverage` float DEFAULT 0,
  `algebra_asked` int(11) DEFAULT 0,
  `algebra_correct` int(11) DEFAULT 0,
  `arithmetic_asked` int(11) DEFAULT 0,
  `arithmetic_correct` int(11) DEFAULT 0,
  `fdp_asked` int(11) DEFAULT 0,
  `fdp_correct` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studentprogress_maths`
--

INSERT INTO `studentprogress_maths` (`username`, `mathsoverall`, `overallaverage`, `algebra_asked`, `algebra_correct`, `arithmetic_asked`, `arithmetic_correct`, `fdp_asked`, `fdp_correct`) VALUES
('alex', 0, 0, 0, 0, 0, 0, 0, 0),
('aqib', 0, 0, 0, 0, 0, 0, 0, 0),
('baz', 0, 0, 0, 0, 0, 0, 0, 0),
('berat', 0, 0, 10, 6, 10, 8, 10, 5),
('burak', 0, 0, 0, 0, 0, 0, 0, 0),
('can', 0, 0, 0, 0, 0, 0, 0, 0),
('ilyas', 0, 0, 0, 0, 0, 0, 0, 0),
('jamie', 0, 0, 0, 0, 0, 0, 0, 0),
('muhanad', 0, 0, 0, 0, 0, 0, 0, 0),
('rohan', 0, 0, 0, 0, 0, 0, 0, 0),
('scoob', 0, 0, 0, 0, 0, 0, 0, 0),
('testingadd', 0, 0, 0, 0, 0, 0, 0, 0),
('testingforeign', 0, 0, 0, 0, 0, 0, 0, 0),
('testuser2', 0, 0, 0, 0, 0, 0, 0, 0),
('yasi', 0, 0, 0, 0, 0, 0, 0, 0),
('yasin', 0, 0, 19, 10, 19, 9, 22, 8);

-- --------------------------------------------------------

--
-- Table structure for table `studentprogress_science`
--

CREATE TABLE `studentprogress_science` (
  `username` varchar(50) NOT NULL,
  `scienceoverall` float DEFAULT 0,
  `overallaverage` float DEFAULT 0,
  `biology_asked` int(11) DEFAULT 0,
  `biology_correct` int(11) DEFAULT 0,
  `chemistry_asked` int(11) DEFAULT 0,
  `chemistry_correct` int(11) DEFAULT 0,
  `physics_asked` int(11) DEFAULT 0,
  `physics_correct` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studentprogress_science`
--

INSERT INTO `studentprogress_science` (`username`, `scienceoverall`, `overallaverage`, `biology_asked`, `biology_correct`, `chemistry_asked`, `chemistry_correct`, `physics_asked`, `physics_correct`) VALUES
('alex', 0, 0, 0, 0, 0, 0, 0, 0),
('aqib', 0, 0, 0, 0, 0, 0, 0, 0),
('baz', 0, 0, 0, 0, 0, 0, 0, 0),
('berat', 0, 0, 0, 0, 0, 0, 0, 0),
('burak', 0, 0, 0, 0, 0, 0, 0, 0),
('can', 0, 0, 10, 7, 10, 4, 10, 3),
('ilyas', 0, 0, 0, 0, 0, 0, 0, 0),
('jamie', 0, 0, 0, 0, 0, 0, 0, 0),
('muhanad', 0, 0, 0, 0, 0, 0, 0, 0),
('rohan', 0, 0, 0, 0, 0, 0, 0, 0),
('scoob', 0, 0, 0, 0, 0, 0, 0, 0),
('testingadd', 0, 0, 0, 0, 0, 0, 0, 0),
('testingforeign', 0, 0, 0, 0, 0, 0, 0, 0),
('testuser2', 0, 0, 0, 0, 0, 0, 0, 0),
('yasi', 0, 0, 0, 0, 0, 0, 0, 0),
('yasin', 0, 0, 41, 24, 40, 22, 40, 20);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`studentid`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `studentprogress_computing`
--
ALTER TABLE `studentprogress_computing`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `studentprogress_maths`
--
ALTER TABLE `studentprogress_maths`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `studentprogress_science`
--
ALTER TABLE `studentprogress_science`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `studentid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `studentprogress_computing`
--
ALTER TABLE `studentprogress_computing`
  ADD CONSTRAINT `studentprogress_computing_ibfk_1` FOREIGN KEY (`username`) REFERENCES `login` (`username`);

--
-- Constraints for table `studentprogress_maths`
--
ALTER TABLE `studentprogress_maths`
  ADD CONSTRAINT `studentprogress_maths_ibfk_1` FOREIGN KEY (`username`) REFERENCES `login` (`username`);

--
-- Constraints for table `studentprogress_science`
--
ALTER TABLE `studentprogress_science`
  ADD CONSTRAINT `studentprogress_science_ibfk_1` FOREIGN KEY (`username`) REFERENCES `login` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
