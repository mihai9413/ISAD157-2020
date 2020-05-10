CREATE TABLE `facebook_friendships` (
  `primary_key_all` int(11) NOT NULL AUTO_INCREMENT,
  `user_ID` int(11) NOT NULL,
  `friends_user_ID` int(11) NOT NULL,
  `friends_first_name` varchar(40) NOT NULL,
  `friends_last_name` varchar(40) NOT NULL,
  PRIMARY KEY (`primary_key_all`),
  KEY `FK_user1_idx` (`user_ID`),
  CONSTRAINT `FK_user1` FOREIGN KEY (`user_ID`) REFERENCES `facebook_users` (`user_ID`),
  CONSTRAINT `FK_user2` FOREIGN KEY (`user_ID`) REFERENCES `facebook_users` (`user_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=104951 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `facebook_users` (
  `user_ID` int(11) NOT NULL,
  `user_first_name` varchar(40) NOT NULL,
  `user_last_name` varchar(40) NOT NULL,
  `gender` varchar(40) NOT NULL,
  `hometown` varchar(40) NOT NULL,
  `city` varchar(40) NOT NULL,
  `relationship_sts` varchar(40) NOT NULL,
  PRIMARY KEY (`user_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `messages` (
  `primary_key_all` int(11) NOT NULL AUTO_INCREMENT,
  `user_ID` int(11) NOT NULL,
  `friends_user_ID` int(11) NOT NULL,
  `dateMSG` date NOT NULL,
  `timeMsg` time NOT NULL,
  `msg` longtext NOT NULL,
  PRIMARY KEY (`primary_key_all`),
  KEY `FK_msg1_idx` (`user_ID`),
  CONSTRAINT `FK_msg1` FOREIGN KEY (`user_ID`) REFERENCES `facebook_users` (`user_ID`),
  CONSTRAINT `FK_msg2` FOREIGN KEY (`user_ID`) REFERENCES `facebook_users` (`user_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5478 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `universities` (
  `primary_key_all` int(11) NOT NULL AUTO_INCREMENT,
  `user_ID` int(11) NOT NULL,
  `university` varchar(80) NOT NULL,
  `start_date` varchar(80) DEFAULT NULL,
  `end_date` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`primary_key_all`),
  KEY `FK_uni_idx` (`user_ID`),
  CONSTRAINT `FK_uni` FOREIGN KEY (`user_ID`) REFERENCES `facebook_users` (`user_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6867 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `workplace` (
  `primary_key_all` int(11) NOT NULL AUTO_INCREMENT,
  `user_ID` int(11) NOT NULL,
  `workplace` varchar(80) NOT NULL,
  `start_date` varchar(80) DEFAULT NULL,
  `end_date` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`primary_key_all`),
  KEY `FK_work_idx` (`user_ID`),
  CONSTRAINT `FK_work` FOREIGN KEY (`user_ID`) REFERENCES `facebook_users` (`user_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6898 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
