CREATE DATABASE cs206finalproject;

CREATE TABLE users
(
    user_id                int auto_increment PRIMARY KEY,
    user_username          varchar(25)  NOT NULL,
    user_email             varchar(255) NOT NULL,
    user_password          varchar(255) NOT NULL,
    user_active            tinyint(1)   DEFAULT 0,
    user_isadmin           tinyint(1)   DEFAULT 0,
    user_ismanager         tinyint(1)   DEFAULT 0,
    user_isuser            tinyint(1)   DEFAULT 0,
);

CREATE TABLE track
(
    trk_id                 int auto_increment PRIMARY KEY,
    trk_name               varchar(25)  NOT NULL,
    trk_artist             varchar(25) NOT NULL,
    trk_description        varchar(1000),
    trk_audio              LONGBLOB NOT NULL,
    trk_picture            LONGBLOB NOT NULL,
    trk_featartist         varchar(100),
    trk_date               date NOT NULL,
    trk_created            timestamp NOT NULL DEFAULT current_timestamp()
);