#ifndef CAN_H
#define CAN_H

/**
 * Simple CAN Library
 *
 * #define CAN_INTERRUPT 1	//set this to enable interrupt driven and buffering version
 * #define CAN_RX_BUFFER_SIZE 2	//only used for Interrupt
 * #define CAN_TX_BUFFER_SIZE 2	//only used for Interrupt
 */

typedef struct{
	unsigned char addr_src;
	unsigned char addr_dest;
	unsigned char port_src;
	unsigned char port_dest;
	unsigned char dlc;
	unsigned char data[8];
}can_message;

typedef enum { normal, mode_sleep, loopback, listenonly, config } can_mode_t ;

/*****************************************************************************
 * Management
 */

void can_init();
void can_setfilter();
void can_setmode(can_mode_t);

/*****************************************************************************
 * Sending
 */

can_message * can_buffer_get();
void can_transmit( can_message *msg );


/*****************************************************************************
 * Receiving
 */

can_message *can_get();
can_message *can_get_nb();

#include "config.h"

#ifndef CAN_INTERRUPT
//this is only needed for Interrupt driven Version
#define can_free(m)
#endif

#endif
